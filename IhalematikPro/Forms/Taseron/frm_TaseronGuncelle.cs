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

namespace IhalematikProUI.Forms.Taseron
{
    public partial class frm_TaseronGuncelle : DevExpress.XtraEditors.XtraForm
    {
        frm_TaseronTanimlama _owner = null;
        public int CurrentJobberId { get; set; }
        public Jobber currentJobber { get; set; }
        public Jobber CurrentJobber
        {
            get
            {
                if (this.currentJobber == null)
                {
                    this.currentJobber = JobberProvider.Instance.GetItem(this.CurrentJobberId);
                }
                return this.currentJobber;
            }
        }

        public frm_TaseronGuncelle(frm_TaseronTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TaseronGuncelle_Shown(object sender, EventArgs e)
        {
            txtAddress.Text = this.CurrentJobber.Address;
            txtAuthorNameSurname.Text = this.CurrentJobber.AuthorNameSurname;
            txtCompanyName.Text = this.CurrentJobber.CompanyName;
            txtCountry.Text = this.CurrentJobber.City;
            txtEmail.Text = this.CurrentJobber.Email;
            txtGSM.Text = this.CurrentJobber.GSM;
            txtScore.Text = this.CurrentJobber.Score;
            txtTelephone.Text = this.CurrentJobber.Telephone;
            txtTaxNumber.Text = this.CurrentJobber.TaxNumber;
            txtTaxOffice.Text = this.CurrentJobber.TaxOffice;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //IsEmptyKontrol();
            this.CurrentJobber.Address = txtAddress.Text;
            this.CurrentJobber.AuthorNameSurname = txtAuthorNameSurname.Text;
            this.CurrentJobber.CompanyName = txtCompanyName.Text;
            this.CurrentJobber.City = txtCountry.Text;
            this.CurrentJobber.Email = txtEmail.Text;
            this.CurrentJobber.GSM = txtGSM.Text;
            this.CurrentJobber.IsActive = true;
            this.CurrentJobber.Score = txtScore.Text;
            this.CurrentJobber.Telephone = txtTelephone.Text;
            this.CurrentJobber.TaxOffice = txtTaxOffice.Text.Trim();
            this.CurrentJobber.TaxNumber = txtTaxNumber.Text.Trim();

            OperationResult result = JobberProvider.Instance.Save(this.CurrentJobber);

            if (result.Success)
            {
                this._owner.LoadGrid();
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Güncelleme Yapıldı...";
                mf.ShowDialog();
                this.Close();
            }

        }
    }
}