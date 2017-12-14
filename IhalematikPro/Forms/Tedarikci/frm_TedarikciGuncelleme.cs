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

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikciGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        frm_TedarikciTanimlama _owner = null;
        public int CurrentSupplierId { get; set; }
        public Supplier currentSupplier { get; set; }
        public Supplier CurrentSupplier
        {
            get
            {
                if (this.currentSupplier == null)
                {
                    this.currentSupplier = SupplierProvider.Instance.GetItem(this.CurrentSupplierId);
                }
                return this.currentSupplier;
            }
        }
        public frm_TedarikciGuncelleme(frm_TedarikciTanimlama Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TedarikciGuncelleme_Shown(object sender, EventArgs e)
        {
            List<SupplierSegment> supplierSegments = SupplierSegmentProvider.Instance.GetItems();
            ddlSegments.Properties.Items.AddRange(supplierSegments);

            //SupplierSegment model = new SupplierSegment(currentVehicle);
            int index = supplierSegments.FindIndex(p => p.Id == this.CurrentSupplier.Segments.FirstOrDefault().Id);
            ddlSegments.SelectedIndex = index;//selectedTitle;
            txtAddress.Text = this.CurrentSupplier.Address;
            txtAuthorNameSurname.Text = this.CurrentSupplier.AuthorNameSurname;
            txtCompanyName.Text = this.CurrentSupplier.CompanyName;
            txtCountry.Text = this.CurrentSupplier.Country;
            txtEmail.Text = this.CurrentSupplier.Email;
            txtGSM.Text = this.CurrentSupplier.GSM;
            txtScore.Text = this.CurrentSupplier.Score;
            txtTelephone.Text = this.CurrentSupplier.Telephone;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.CurrentSupplier.Address = txtAddress.Text;
            this.CurrentSupplier.AuthorNameSurname = txtAuthorNameSurname.Text;
            this.CurrentSupplier.CompanyName = txtCompanyName.Text;
            this.CurrentSupplier.Country = txtCountry.Text;
            this.CurrentSupplier.Email = txtEmail.Text;
            this.CurrentSupplier.GSM = txtGSM.Text;
            this.CurrentSupplier.IsActive = true;
            this.CurrentSupplier.Score = txtScore.Text;
            this.CurrentSupplier.Telephone = txtScore.Text;

            OperationResult result = SupplierProvider.Instance.Save(this.CurrentSupplier);

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