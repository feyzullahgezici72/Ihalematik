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
            //this.CurrentWorker = 


            if (CurrentWorker != null)
            {
                txtAGI.Text = CurrentWorker.AGIFare.Amount.ToString();
                txtBaseFare.Text = CurrentWorker.BaseFare.Amount.ToString();
                txtExtraFare.Text = CurrentWorker.ExtraFare.Amount.ToString();
                txtFoodFare.Text = CurrentWorker.FoodFare.Amount.ToString();
                txtHotelFare.Text = CurrentWorker.HotelFare.Amount.ToString();
                txtIncomeTaxFare.Text = CurrentWorker.IncomeTaxFare.Amount.ToString();
                txtISGFare.Text = CurrentWorker.ISGFare.Amount.ToString();
                txtSeveranceFare.Text = CurrentWorker.SeveranceFare.Amount.ToString();
                txtSGKPrimFare.Text = CurrentWorker.SGKPrimFare.Amount.ToString();
                txtStampTaxFare.Text = CurrentWorker.StampTaxFare.Amount.ToString();
                txtTravelFare.Text = CurrentWorker.TravelFare.Amount.ToString();
                txtWorklesFonFare.Text = CurrentWorker.WorklesFonFare.Amount.ToString();
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

        private void rbAsgariUcret_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.rbNormal.Checked)
            {
                double asgariUcret = 1404;
                txtBaseFare.Text = asgariUcret.ToString();
                txtSGKPrimFare.Text = Math.Round((asgariUcret / 100 * 13), 2).ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            WorkerModel model = new WorkerModel(this.currentWorker);
            //model.Code = txtCode.Text;
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
        }
    }
}