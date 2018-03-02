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
using SimpleApplicationBase.BL.Base;

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleBilgisiDetay : DevExpress.XtraEditors.XtraForm
    {
        public int TenderId { get; set; }
        private Tender tender { get; set; }
        public Tender Tender
        {
            get
            {
                if (this.tender == null)
                {
                    this.tender = TenderProvider.Instance.GetItem(this.TenderId);
                }
                return this.tender;
            }
            set
            {
                this.tender = value;
            }
        }
        public frm_IhaleBilgisiDetay()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_IhaleBilgisiDetay_Load(object sender, EventArgs e)
        {
            txtTeklifNo.Text = this.Tender.Number.ToString();
            txtAciklama.Text = this.Tender.Description;
            LastOfferDate.DateTime = this.Tender.LastOfferDate.Value;
            txtcompanyName.Text = this.Tender.CompanyName;
            txtEkapNumber.Text = this.Tender.EkapNumber;
            txtType.Text = this.Tender.Type;
            txtScope.Text = this.Tender.Scope;
            txtProcedure.Text = this.Tender.Procedure;
            txtPlace.Text = this.Tender.Place;
            txtManagement.Text = this.Tender.Management;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Tender != null)
            {
                //txtTeklifNo.Text = this.Tender.Number.ToString();
                this.Tender.Description = txtAciklama.Text;
                this.Tender.LastOfferDate = LastOfferDate.DateTime;
                this.Tender.CompanyName = txtcompanyName.Text;
                this.Tender.EkapNumber = txtEkapNumber.Text;
                this.Tender.Type = txtType.Text;
                this.Tender.Scope = txtScope.Text;
                this.Tender.Procedure = txtProcedure.Text;
                this.Tender.Place = txtPlace.Text;
                this.Tender.Management = txtManagement.Text;
                OperationResult res = TenderProvider.Instance.Save(this.Tender);
                if (res.Success)
                {
                    MessageBox.Show("Ihale bilgileri güncellendi.");
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu.");
                }
            }
        }
    }
}