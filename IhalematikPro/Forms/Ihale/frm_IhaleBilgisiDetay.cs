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

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleBilgisiDetay : DevExpress.XtraEditors.XtraForm
    {
        public int TenderId { get; set; }
        public Tender Tender
        {
            get
            {
                return TenderProvider.Instance.GetItem(this.TenderId);
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
            txtLastOfferDate.Text = this.Tender.LastOfferDate.Value == null ? string.Empty : this.Tender.LastOfferDate.Value.ToShortDateString();
            txtcompanyName.Text = this.Tender.CompanyName;
            txtEkapNumber.Text = this.Tender.EkapNumber;
            txtType.Text = this.Tender.Type;
            txtScope.Text = this.Tender.Scope;
            txtProcedure.Text = this.Tender.Procedure;
            txtPlace.Text = this.Tender.Place;
            txtManagement.Text = this.Tender.Management;
        }
    }
}