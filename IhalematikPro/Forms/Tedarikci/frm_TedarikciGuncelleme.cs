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
using IhalematikProUI.Model;

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
            List<DropDownModel> models = new List<DropDownModel>();
            foreach (SupplierSegment item in supplierSegments)
            {
                DropDownModel model = new DropDownModel();
                model.Id = item.Id;
                model.Text = item.Name;
                models.Add(model);
            }
            checkedComboboxEditSupplierSegments.Properties.DataSource = models;
            checkedComboboxEditSupplierSegments.Properties.DisplayMember = "Text";
            checkedComboboxEditSupplierSegments.Properties.ValueMember = "Id";
            checkedComboboxEditSupplierSegments.Properties.NullText = string.Empty;
            checkedComboboxEditSupplierSegments.Properties.SeparatorChar = ';';


            txtAddress.Text = this.CurrentSupplier.Address;
            txtAuthorNameSurname.Text = this.CurrentSupplier.AuthorNameSurname;
            txtCompanyName.Text = this.CurrentSupplier.CompanyName;
            txtCountry.Text = this.CurrentSupplier.Country;
            txtEmail.Text = this.CurrentSupplier.Email;
            txtGSM.Text = this.CurrentSupplier.GSM;
            txtScore.Text = this.CurrentSupplier.Score;
            txtTelephone.Text = this.CurrentSupplier.Telephone;
            if (this.CurrentSupplier.Segments != null)
            {
                string selectedSuppliersSegments = string.Join(";", this.CurrentSupplier.Segments.Select(p => p.Id));
                checkedComboboxEditSupplierSegments.SetEditValue(selectedSuppliersSegments);
            }
        }
        public bool IsEmptyKontrol()
        {
            object items = checkedComboboxEditSupplierSegments.Properties.GetCheckedItems();
          if (string.IsNullOrEmpty((string)items))
            {
                dxErrorProvider1.SetError(checkedComboboxEditSupplierSegments, "En az bir Faaliyet alanı seçilmelidir ", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            object items1 = checkedComboboxEditSupplierSegments.Properties.GetCheckedItems();
            if (!string.IsNullOrEmpty((string)items1))
            {
                IsEmptyKontrol();
                this.CurrentSupplier.Address = txtAddress.Text;
                this.CurrentSupplier.AuthorNameSurname = txtAuthorNameSurname.Text;
                this.CurrentSupplier.CompanyName = txtCompanyName.Text;
                this.CurrentSupplier.Country = txtCountry.Text;
                this.CurrentSupplier.Email = txtEmail.Text;
                this.CurrentSupplier.GSM = txtGSM.Text;
                this.CurrentSupplier.IsActive = true;
                this.CurrentSupplier.Score = txtScore.Text;
                this.CurrentSupplier.Telephone = txtTelephone.Text;

                object items = checkedComboboxEditSupplierSegments.Properties.GetCheckedItems();
                string[] selectedSegments = items.ToString().Split(';');
                if (selectedSegments != null && selectedSegments.Count() != 0)
                {
                    this.CurrentSupplier.Segments = new List<SupplierSegment>();
                    foreach (var item in selectedSegments)
                    {
                        this.CurrentSupplier.Segments.Add(new SupplierSegment() { Id = int.Parse(item) });
                    }
                }

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

        private void checkedComboboxEditSupplierSegments_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            txtCompanyName.Focus();
        }
    }
}