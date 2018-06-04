using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System.IO;
using ExcelDataReader;
using IhalematikProUI.Forms;
using IhalematikProUI.Forms.Base;
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProBL.Manager;

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

       
        public void InitilalizeForm()
        {
            this.LoadWorkerTitles();
        }

        public void LoadWorkerTitles()
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
            if (!string.IsNullOrEmpty(txtWorkerTitle.Text.Trim()))
            {
                models = models.Where(p => p.Title.Name.ToLower().Contains(txtWorkerTitle.Text.Trim().ToLower())).ToList();
            }
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                models = models.Where(p => p.IsActive).ToList();
                grdWorker.DataSource = models;
                colEdit.Visible = true;
                colPasive.Visible = true;
                colActive.Visible = false;
                lblRecordCount.Text = models.Count.ToString();
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                models = models.Where(p => !p.IsActive).ToList();
                grdWorker.DataSource = models;
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
                if (rbAsgariUcret.Checked)
                {
                    model.WorkerType = WorkerTypesEnum.MinimumSalary;
                }
                else if (rbNormal.Checked)
                {
                    model.WorkerType = WorkerTypesEnum.NormalSalary;
                }

                else
                {
                    model.WorkerType = WorkerTypesEnum.NetSalary;
                }

                if (txtBaseFare.Text != "")
                {
                    model.BaseFare = new Fare(double.Parse(txtBaseFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.BaseFare = new Fare(0);
                }
                if (txtSGKPrimFare.Text != "")
                {
                    model.SGKPrimFare = new Fare(double.Parse(txtSGKPrimFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.SGKPrimFare = new Fare(0);
                }
                if (txtWorklesFonFare.Text != "")
                {
                    model.WorklesFonFare = new Fare(double.Parse(txtWorklesFonFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.WorklesFonFare = new Fare(0);
                }
                if (txtIncomeTaxFare.Text != "")
                {
                    model.IncomeTaxFare = new Fare(double.Parse(txtIncomeTaxFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.IncomeTaxFare = new Fare(0);
                }
                if (txtSeveranceFare.Text != "")
                {
                    model.SeveranceFare = new Fare(double.Parse(txtSeveranceFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.SeveranceFare = new Fare(0);
                }
                if (txtStampTaxFare.Text != "")
                {
                    model.StampTaxFare = new Fare(double.Parse(txtStampTaxFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.StampTaxFare = new Fare(0);
                }
                if (txtAGI.Text != "")
                {
                    model.AGIFare = new Fare(double.Parse(txtAGI.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.AGIFare = new Fare(0);
                }
                if (txtFoodFare.Text != "")
                {
                    model.FoodFare = new Fare(double.Parse(txtFoodFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.FoodFare = new Fare(0);
                }
                if (txtTravelFare.Text != "")
                {
                    model.TravelFare = new Fare(double.Parse(txtTravelFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.TravelFare = new Fare(0);
                }
                if (txtHotelFare.Text != "")
                {
                    model.HotelFare = new Fare(double.Parse(txtHotelFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.HotelFare = new Fare(0);
                }
                if (txtISGFare.Text != "")
                {
                    model.ISGFare = new Fare(double.Parse(txtISGFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.ISGFare = new Fare(0);
                }
                if (txtExtraFare.Text != "")
                {
                    model.ExtraFare = new Fare(double.Parse(txtExtraFare.Text.Replace("TL", string.Empty)));
                }
                else
                {
                    model.ExtraFare = new Fare(0);
                }

                model.Save();
                LoadGrid();
                btnTemizle.PerformClick();
                //frm_MesajFormu mf = new frm_MesajFormu();
                //mf.lblMesaj.Text = "Çalışan kaydı yapıldı...";
                //mf.ShowDialog();
                UIPopupManager.Instance.ShowPopup();
            }
        }
        public bool IsEmptyKontrol()
        {
            if (ddlTitles.SelectedIndex < 0)
            {
                dxErrorProvider1.SetError(ddlTitles, "Ünvan seçilmelidir", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (txtBaseFare.Text == null)
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
                        txtIncomeTaxFare.Text = (minimumWage * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString("c2");
                    }
                    else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                    {
                        txtSGKPrimFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString("c2");
                    }
                    else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                    {
                        txtStampTaxFare.Text = (minimumWage * double.Parse(item.Value) / 100000).ToString("c2");
                    }
                    else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                    {
                        txtWorklesFonFare.Text = (minimumWage * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString("c2");
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
            panelControl2.Visible = true;
            txtAGI.Focus();
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
                            txtIncomeTaxFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString("c2");
                        }
                        else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                        {
                            txtSGKPrimFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString("c2");
                        }
                        else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                        {
                            txtStampTaxFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100000).ToString("c2");
                        }
                        else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                        {
                            txtWorklesFonFare.Text = (SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(minimumWage.Value) * SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(item.Value) / 100).ToString("c2");
                        }
                    }
                }
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            panelControl2.Visible = true;
            
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
            txtBaseFare.Focus();
            frm_CalisanEkle frm = new frm_CalisanEkle(this);
            frm.ShowDialog();
         
        }

        private void btnGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_Calisan_Guncelleme cg = new frm_Calisan_Guncelleme(this);
            this.FocusedRowHandle = gridViewWorker.FocusedRowHandle;

            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewWorker.GetFocusedRowCellValue("Id"));
            cg.CurrentWorkerId = id;

            //kayitMenusu.Visible = false;
            this.Opacity = 10;
            this.Enabled = false;
            cg.ShowDialog();
            this.Enabled = true;
            this.Opacity = 100;
            //kayitMenusu.Visible = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ddlTitles.SelectedIndex = -1;
            rbNormal.Checked = false;
            rbAsgariUcret.Checked = false;
            txtAGI.Text = "";
            txtBaseFare.Text = "";
            txtExtraFare.Text = "";
            txtFoodFare.Text = "";
            txtHotelFare.Text = "";
            txtIncomeTaxFare.Text = "";
            txtISGFare.Text = "";
            txtSeveranceFare.Text = "";
            txtSGKPrimFare.Text = "";
            txtStampTaxFare.Text = "";
            txtTravelFare.Text = "";
            txtWorklesFonFare.Text = "";
            
        }


        private void ddlTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTitles.SelectedItem == null)
            {
                return;
            }
            TitleModel selectedItem = (TitleModel)ddlTitles.SelectedItem;
            Worker worker = WorkerProvider.Instance.GetItems("TitleId", selectedItem.Id).FirstOrDefault();
            if (worker != null)
            {
                if (!worker.IsActive)
                {
                    DialogResult result = MessageBox.Show("Tanımlamaya çalıştığınız ünvan pasif'e ayırmışsınız. Aktifleştirmek istermisiniz?", "Pasif", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        worker.IsActive = true;
                        WorkerProvider.Instance.Save(worker);
                        this.LoadGrid();
                    }
                    ddlTitles.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Tanımlamaya çalıştığınız ünvan zaten tanımlı. Güncelleme yapabilirsiniz.");
                    ddlTitles.SelectedItem = null;
                }

            }
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void frm_CalisanTanimlama_Shown(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //LoadingManager.Instance.Show(this);
            this.InitilalizeForm();
            this.LoadGrid();
            //LoadingManager.Instance.Hide();;
            //this.Enabled = true;
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
            DialogResult result = MessageBox.Show("Aktif yapmak istediginzden emin misiniz?", "Aktif", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtBaseFare.Focus();
            panelControl2.Visible = false;
            txtSGKPrimFare.Text = "0";
            txtWorklesFonFare.Text = "0";
            txtIncomeTaxFare.Text = "0";
            txtSeveranceFare.Text = "0";
            txtStampTaxFare.Text = "0";
            txtAGI.Text = "0";
            txtFoodFare.Text = "0";
            txtTravelFare.Text = "0";
            txtHotelFare.Text = "0";
            txtISGFare.Text = "0";
            txtExtraFare.Text = "0";
        }

        private void txtBaseFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && rbNormal.Checked == true)
            {
                txtAGI.Focus();
            }
            if (e.KeyChar == 13 && rbAsgariUcret.Checked == true)
            {
                txtAGI.Focus();
            }
            if (e.KeyChar == 13 && rbBaseAmount.Checked == true)
            {
                btnKaydet.Focus();
            }
        }

        private void txtExtraFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnKaydet.Focus();
            }
        }

        private void rbNormal_Click(object sender, EventArgs e)
        {
            txtBaseFare.Focus();
        }

        private void rbAsgariUcret_Click(object sender, EventArgs e)
        {
            txtBaseFare.Focus();
        }

        private void rbBaseAmount_Click(object sender, EventArgs e)
        {
            txtBaseFare.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            txtWorkerTitle.Focus();
        }

        private void txtWorkerTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                simpleButton3.PerformClick();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdWorker);
                if (!isSuccess)
                {
                    MessageBox.Show("Program beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }
    }
}