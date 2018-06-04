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
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using IhalematikProBL.Enum;
using IhalematikProUI.Forms.Base;
using System.Globalization;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_Calisan_Guncelleme : DevExpress.XtraEditors.XtraForm
    {
        frm_CalisanTanimlama _owner = null;
        public int CurrentWorkerId { get; set; }
        public Worker currentWorker { get; set; }
        public Worker CurrentWorker
        {
            get
            {
                if (this.currentWorker == null)
                {
                    this.currentWorker = WorkerProvider.Instance.GetItem(this.CurrentWorkerId);
                }
                return this.currentWorker;
            }
        }

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

        public bool IsCalculatedMinimumWage = false;

        public string BaseFare = string.Empty;

        public frm_Calisan_Guncelleme(frm_CalisanTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this._owner.LoadGrid();
        }

        private void frm_Calisan_Guncelleme_Load(object sender, EventArgs e)
        {
            List<TitleModel> models = UITitleManager.Instance.GetTitles();
            ddlTitles.Properties.Items.AddRange(models);
            ddlTitles.ReadOnly = true;

            if (CurrentWorker != null)
            {
                txtAGI.Text = CurrentWorker.AGIFare.Amount.ToString("c2");
                txtBaseFare.Text = CurrentWorker.BaseFare.Amount.ToString("c2");
                this.BaseFare = CurrentWorker.BaseFare.Amount.ToString("c2");
                txtExtraFare.Text = CurrentWorker.ExtraFare.Amount.ToString("c2");
                txtFoodFare.Text = CurrentWorker.FoodFare.Amount.ToString("c2");
                txtHotelFare.Text = CurrentWorker.HotelFare.Amount.ToString("c2");
                txtIncomeTaxFare.Text = CurrentWorker.IncomeTaxFare.Amount.ToString("c2");
                txtISGFare.Text = CurrentWorker.ISGFare.Amount.ToString("c2");
                txtSeveranceFare.Text = CurrentWorker.SeveranceFare.Amount.ToString("c2");
                txtSGKPrimFare.Text = CurrentWorker.SGKPrimFare.Amount.ToString("c2");
                txtStampTaxFare.Text = CurrentWorker.StampTaxFare.Amount.ToString("c2");
                txtTravelFare.Text = CurrentWorker.TravelFare.Amount.ToString("c2");
                txtWorklesFonFare.Text = CurrentWorker.WorklesFonFare.Amount.ToString("c2");
                int index = models.FindIndex(p => p.Id == CurrentWorker.Title.Id);
                ddlTitles.SelectedIndex = index;//selectedTitle;

                switch (currentWorker.WorkerType)
                {
                    case WorkerTypesEnum.MinimumSalary:
                        rbAsgariUcret.Checked = true;
                        break;
                    case WorkerTypesEnum.NormalSalary:
                        rbNormal.Checked = true;
                        break;
                    case WorkerTypesEnum.NetSalary:
                        rbNetSalary.Checked = true;
                        break;
                    default:
                        break;
                }
                //if (CurrentWorker.IsNormal)
                //{
                //    rbNormal.Checked = true;
                //}
                //else
                //{
                //    rbAsgariUcret.Checked = true;
                //}
            }

        }

        private void txtBaseFare_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBaseFare.Text))
            {
                txtBaseFare.Text = "0";
            }
            double a;
            double.TryParse(txtBaseFare.Text.Replace("TL", ""), NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out a);

            double minimumWage = double.Parse(txtBaseFare.Text.Replace("TL", ""));
            if (this.Rules != null && rbNormal.Checked)
            {
                foreach (var item in this.Rules)
                {
                    if (item.RuleType == RuleTypesEnum.IncomeTaxFare)
                    {
                        txtIncomeTaxFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString("c2");
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
                        txtWorklesFonFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString("c2");
                    }
                }
                //if (!this.IsCalculatedMinimumWage)
                //{
                //    this.BaseFare = txtBaseFare.Text;
                //}
            }
        }

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
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
                            txtIncomeTaxFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100).ToString("c2");
                        }
                        else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                        {
                            txtSGKPrimFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100).ToString("c2");
                        }
                        else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                        {
                            txtStampTaxFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100000).ToString("c2");
                        }
                        else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                        {
                            txtWorklesFonFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100).ToString("c2");
                        }
                    }
                }
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            this.IsCalculatedMinimumWage = false;
            if (this.rbNormal.Checked)
            {
                //if (string.IsNullOrEmpty(this.BaseFare))
                //{
                txtBaseFare.Text = this.BaseFare;
                //}
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            WorkerModel model = new WorkerModel(this.currentWorker);
            //model.Code = txtCode.Text;
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

            // model.IsNormal = rbNormal.Checked;
            model.BaseFare = new Fare(double.Parse(txtBaseFare.Text.Replace("TL", string.Empty)));
            model.SGKPrimFare = new Fare(double.Parse(txtSGKPrimFare.Text.Replace("TL", string.Empty)));

            model.WorklesFonFare = new Fare(double.Parse(txtWorklesFonFare.Text.Replace("TL", string.Empty)));
            model.IncomeTaxFare = new Fare(double.Parse(txtIncomeTaxFare.Text.Replace("TL", string.Empty)));
            model.SeveranceFare = new Fare(double.Parse(txtSeveranceFare.Text.Replace("TL", string.Empty)));

            model.StampTaxFare = new Fare(double.Parse(txtStampTaxFare.Text.Replace("TL", string.Empty)));
            model.AGIFare = new Fare(double.Parse(txtAGI.Text.Replace("TL", string.Empty)));
            model.FoodFare = new Fare(double.Parse(txtFoodFare.Text.Replace("TL", string.Empty)));
            model.TravelFare = new Fare(double.Parse(txtTravelFare.Text.Replace("TL", string.Empty)));
            model.HotelFare = new Fare(double.Parse(txtHotelFare.Text.Replace("TL", string.Empty)));
            model.ISGFare = new Fare(double.Parse(txtISGFare.Text.Replace("TL", string.Empty)));
            model.ExtraFare = new Fare(double.Parse(txtExtraFare.Text.Replace("TL", string.Empty))); //.Replace("TL", string.Empty) SAMET ekledi

            model.Save();
            //frm_MesajFormu mf = new frm_MesajFormu();
            //mf.lblMesaj.Text = "Kayıt Güncellendi...";
            //mf.ShowDialog();
            UIPopupManager.Instance.ShowPopup();
            this._owner.LoadGrid();
            this.Close();

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
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

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBaseFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && rbNormal.Checked==true)
            {
                txtAGI.Focus();
            }
            if (e.KeyChar == 13 && rbAsgariUcret.Checked == true)
            {
                txtAGI.Focus();
            }
            if (e.KeyChar == 13 && rbNetSalary.Checked == true)
            {
                btnGuncelle.Focus();
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

        private void rbNetSalary_Click(object sender, EventArgs e)
        {
            txtBaseFare.Focus();
        }

        private void txtExtraFare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnGuncelle.Focus();
            }
        }
    }
}