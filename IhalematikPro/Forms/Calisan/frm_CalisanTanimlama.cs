using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System.IO;
using ExcelDataReader;
using IhalematikProUI.Forms;
using System.Threading;
using IhalematikProUI.Forms.Base;

namespace IhalematikPro.Forms
{
    public partial class frm_CalisanTanimlama : IhalematikBaseForm
    {
        List<Worker> workers = new List<Worker>();

        private List<IhalematikProBL.Entity.Rule> rules = null;
        public List<IhalematikProBL.Entity.Rule> Rules
        {
            get
            {
                if (this.rules == null)
                {
                    this.Rules = RuleProvider.Instance.GetItems();
                }
                return this.rules;
            }
            set
            {
                this.rules = value;
            }
        }

        public int FocusedRowHandle = 0;

        public int SelectedTitleId = 0;

        public frm_CalisanTanimlama()
        {
            InitializeComponent();
            base.ScreenMethod();
            //this._owner = this;
            //getExcel();
        }

        public bool IsCalculatedMinimumWage = false;

        public string BaseFare = string.Empty;

        public void getExcel()
        {
            FileStream stream = System.IO.File.Open(@"E:\2017BirimFiyat.xlsx", FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //excelReader.IsFirstRowAsColumnNames = true;
            //DataSet result = excelReader.AsDataSet();
            int i = 0;
            while (excelReader.Read())
            {
                if (i > 1)
                {
                    string pozno = excelReader.GetString(0);
                    string description = excelReader.GetString(1);
                    string unit = excelReader.GetString(2);
                    double unitprice = excelReader.GetDouble(3);

                    if (!string.IsNullOrEmpty(pozno) && !string.IsNullOrEmpty(description) && !string.IsNullOrEmpty(unit))
                    {

                        Poz poz = new Poz();
                        poz.Number = pozno;
                        poz.Description = description;
                        poz.Unit = unit;
                        poz.UnitPrice = unitprice;


                        PozProvider.Instance.Save(poz);
                    }

                    //List<Country> countries = CountryProvider.Instance.GetItems("Code", code);

                    //foreach (Country country in countries)
                    //{

                    //    string PhoneAreacode = excelReader.GetString(1);
                    //    string PassaportMandotry = excelReader.GetString(2);

                    //    string turkce = excelReader.GetString(3);
                    //    string ingilizce = excelReader.GetString(4);
                    //    string hirvatca = excelReader.GetString(5);

                    //    CountryProvider.Instance.Save(country);
                    //}

                }
                i++;
            }

        }
        public void InitilalizeForm()
        {
            ddlTitles.Properties.Items.Clear();
            List<TitleModel> models = UITitleManager.Instance.GetTitles();
            ddlTitles.Properties.Items.AddRange(models);
            if (this.SelectedTitleId != 0)
            {
                TitleModel selectedTite = models.Where(p => p.Id == this.SelectedTitleId).FirstOrDefault();
                int selectedIndex = models.IndexOf(selectedTite);
                ddlTitles.SelectedIndex = selectedIndex;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_CalisanTanimlama_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Frm_CalisanTanimlama_KeyDown);
        }

        private void Frm_CalisanTanimlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frm_CalisanEkle frm = new frm_CalisanEkle(this);
                frm.ShowDialog();
            }

        }

        public void LoadGrid()
        {
            List<WorkerModel> models = UIWorkerManager.Instance.GetWorkers();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdWorker.DataSource = models.Where(p => p.IsActive);
                colEdit.Visible = true;
                colPasive.Visible = true;
                colActive.Visible = false;
                lblRecordCount.Text = models.Count.ToString();
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdWorker.DataSource = models.Where(p => !p.IsActive);
                colPasive.Visible = false;
                colEdit.Visible = false;
                colActive.Visible = true;
                lblRecordCount.Text = models.Count.ToString();
            }

            if (this.FocusedRowHandle != 0)
            {
                gridViewWorker.FocusedRowHandle = this.FocusedRowHandle;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool IsEmpty = IsEmptyKontrol();
            if (!IsEmpty)
            {
                WorkerModel model = new WorkerModel();
                model.IsActive = true;
                model.TitleId = ((TitleModel)ddlTitles.SelectedItem).Id.Value;
                model.IsNormal = rbNormal.Checked;
                model.BaseFare = new Fare(double.Parse(txtBaseFare.Text));
                model.SGKPrimFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtSGKPrimFare.Text));

                model.WorklesFonFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorklesFonFare.Text));
                model.IncomeTaxFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtIncomeTaxFare.Text));
                model.SeveranceFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtSeveranceFare.Text));

                model.StampTaxFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtStampTaxFare.Text));
                model.AGIFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtAGI.Text));
                model.FoodFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtFoodFare.Text));
                model.TravelFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtTravelFare.Text));
                model.HotelFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtHotelFare.Text));
                model.ISGFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtISGFare.Text));
                model.ExtraFare = new Fare(SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtExtraFare.Text));

                model.Save();
                LoadGrid();
            }
        }
        public bool IsEmptyKontrol()
        {
            if (ddlTitles.SelectedIndex < 0)
            {
                dxErrorProvider1.SetError(ddlTitles, "Ünvan seçilmelidir", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (txtBaseFare.Text==null)
            {
                dxErrorProvider1.SetError(txtBaseFare, "Net Maaşı belirtiniz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }
        private void txtBaseFare_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBaseFare.Text))
            {
                txtBaseFare.Text = "0";
            }
            double minimumWage = double.Parse(txtBaseFare.Text.Replace("TL", ""));
            if (this.Rules != null && rbNormal.Checked)
            {
                foreach (var item in this.Rules)
                {
                    if (item.RuleType == RuleTypesEnum.IncomeTaxFare)
                    {
                        txtIncomeTaxFare.Text = (minimumWage * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString();
                    }
                    else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                    {
                        txtSGKPrimFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString();
                    }
                    else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                    {
                        txtStampTaxFare.Text = (minimumWage * double.Parse(item.Value) / 100000).ToString();
                    }
                    else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                    {
                        txtWorklesFonFare.Text = (minimumWage * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString();
                    }
                }
                if (!this.IsCalculatedMinimumWage)
                {
                    this.BaseFare = txtBaseFare.Text;
                }
            }
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            this.IsCalculatedMinimumWage = true;
            if (this.rbAsgariUcret.Checked)
            {
                IhalematikProBL.Entity.Rule minimumWage = this.Rules.Where(p => p.RuleType == RuleTypesEnum.MinimumWage).FirstOrDefault();
                txtBaseFare.Text = minimumWage.Value;
                if (this.Rules != null)
                {
                    foreach (var item in this.Rules)
                    {
                        if (item.RuleType == RuleTypesEnum.IncomeTaxFare)
                        {
                            txtIncomeTaxFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString();
                        }
                        else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                        {
                            txtSGKPrimFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString();
                        }
                        else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                        {
                            txtStampTaxFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100000).ToString();
                        }
                        else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                        {
                            txtWorklesFonFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString();
                        }
                    }
                }
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.IsCalculatedMinimumWage = false;
            if (this.rbNormal.Checked)
            {
                //if (string.IsNullOrEmpty(this.BaseFare))
                //{
                txtBaseFare.Text = this.BaseFare;
                //}
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_CalisanEkle frm = new frm_CalisanEkle(this);

            frm.ShowDialog();
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Calisan_Guncelleme cg = new frm_Calisan_Guncelleme(this);
            this.FocusedRowHandle = gridViewWorker.FocusedRowHandle;

            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewWorker.GetFocusedRowCellValue("Id"));
            cg.CurrentWorkerId = id;

            kayitMenusu.Visible = false;
            this.Opacity = 10;
            this.Enabled = false;
            cg.ShowDialog();
            this.Enabled = true;
            this.Opacity = 100;
            kayitMenusu.Visible = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ddlTitles.SelectedIndex = -1;
            rbNormal.Checked = false;
            rbAsgariUcret.Checked = false;
            txtAGI.ResetText();
            txtBaseFare.ResetText();
            txtExtraFare.ResetText();
            txtFoodFare.ResetText();
            txtHotelFare.ResetText();
            txtIncomeTaxFare.ResetText();
            txtISGFare.ResetText();
            txtSeveranceFare.ResetText();
            txtSGKPrimFare.ResetText();
            txtStampTaxFare.ResetText();
            txtTravelFare.ResetText();
            txtWorklesFonFare.ResetText();

        }

        private void ddlTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTitles.SelectedItem == null)
            {
                return;
            }
            TitleModel selectedItem = (TitleModel)ddlTitles.SelectedItem;
            List<Worker> workers = WorkerProvider.Instance.GetItems("TitleId", selectedItem.Id);
            if (workers.Count != 0)
            {
                MessageBox.Show("Bu unvanda tanimla calisan vardir");
                ddlTitles.SelectedItem = null;
            }
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void frm_CalisanTanimlama_Shown(object sender, EventArgs e)
        {
            this.InitilalizeForm();
            this.LoadGrid();
        }

        private void btnPasive_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinizden emin misiniz?", "Pasif", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewWorker.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewWorker.GetFocusedRowCellValue("Id"));
                Worker selectedWorker = WorkerProvider.Instance.GetItem(id);
                selectedWorker.IsActive = false;
                WorkerProvider.Instance.Save(selectedWorker);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediginzden emin misiniz?", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewWorker.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewWorker.GetFocusedRowCellValue("Id"));
                Worker selectedWorker = WorkerProvider.Instance.GetItem(id);
                selectedWorker.IsActive = true;
                WorkerProvider.Instance.Save(selectedWorker);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {

        }
    }
}