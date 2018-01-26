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
                txtAGI.Text = CurrentWorker.AGIFare.Amount.ToString("c");
                txtBaseFare.Text = CurrentWorker.BaseFare.Amount.ToString("c");
                this.BaseFare = CurrentWorker.BaseFare.Amount.ToString("c");
                txtExtraFare.Text = CurrentWorker.ExtraFare.Amount.ToString("c");
                txtFoodFare.Text = CurrentWorker.FoodFare.Amount.ToString("c");
                txtHotelFare.Text = CurrentWorker.HotelFare.Amount.ToString("c");
                txtIncomeTaxFare.Text = CurrentWorker.IncomeTaxFare.Amount.ToString("c");
                txtISGFare.Text = CurrentWorker.ISGFare.Amount.ToString("c");
                txtSeveranceFare.Text = CurrentWorker.SeveranceFare.Amount.ToString("c");
                txtSGKPrimFare.Text = CurrentWorker.SGKPrimFare.Amount.ToString("c");
                txtStampTaxFare.Text = CurrentWorker.StampTaxFare.Amount.ToString("c");
                txtTravelFare.Text = CurrentWorker.TravelFare.Amount.ToString("c");
                txtWorklesFonFare.Text = CurrentWorker.WorklesFonFare.Amount.ToString("c");
                int index = models.FindIndex(p => p.Id == CurrentWorker.Title.Id);
                ddlTitles.SelectedIndex = index;//selectedTitle;
                if (CurrentWorker.IsNormal)
                {
                    rbNormal.Checked = true;
                }
                else
                {
                    rbAsgariUcret.Checked = true;
                }
            }

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
                        txtIncomeTaxFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString("c");
                    }
                    else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                    {
                        txtSGKPrimFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString("c");
                    }
                    else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                    {
                        txtStampTaxFare.Text = (minimumWage * double.Parse(item.Value) / 100000).ToString("c");
                    }
                    else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                    {
                        txtWorklesFonFare.Text = (minimumWage * double.Parse(item.Value) / 100).ToString("c");
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
                            txtIncomeTaxFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100).ToString("c");
                        }
                        else if (item.RuleType == RuleTypesEnum.SGKPrimFare)
                        {
                            txtSGKPrimFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100).ToString("c");
                        }
                        else if (item.RuleType == RuleTypesEnum.StampTaxFare)
                        {
                            txtStampTaxFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100000).ToString("c");
                        }
                        else if (item.RuleType == RuleTypesEnum.WorklesFonFare)
                        {
                            txtWorklesFonFare.Text = (double.Parse(minimumWage.Value) * double.Parse(item.Value) / 100).ToString("c");
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            WorkerModel model = new WorkerModel(this.currentWorker);
            //model.Code = txtCode.Text;
            model.TitleId = ((TitleModel)ddlTitles.SelectedItem).Id.Value;
            model.IsNormal = rbNormal.Checked;
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
            frm_MesajFormu mf = new frm_MesajFormu();
            mf.lblMesaj.Text = "Kayıt Güncellendi...";
            mf.ShowDialog();
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
    }
}