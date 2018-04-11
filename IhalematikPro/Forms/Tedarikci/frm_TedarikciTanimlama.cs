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
using System.Threading;
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;
using SimpleApplicationBase.BL.Base;
using IhalematikProUI.Forms.Tedarikci;
using IhalematikProUI.Model;
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProBL.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_TedarikciTanimlama : IhalematikBaseForm
    {
        public int FocusedRowHandle = 0;

        public frm_TedarikciTanimlama()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void frm_TedarikciTanimlama_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Frm_TedarikciTanimlama_KeyDown);
        }

        private void Frm_TedarikciTanimlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frm_FaalitetAlaniEkle frm = new frm_FaalitetAlaniEkle(this);
                frm.ShowDialog();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_FaalitetAlaniEkle FAE = new frm_FaalitetAlaniEkle(this);
            FAE.ShowDialog();
        }

        private void frm_TedarikciTanimlama_Shown(object sender, EventArgs e)
        {
            //this.Enabled = false;
            //LoadingManager.Instance.Show(this);
            this.LoadSupplierSegments();
            this.LoadGrid();
            //LoadingManager.Instance.Hide();;
            //this.Enabled = true;
        }

        public void LoadSupplierSegments()
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

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            object items = checkedComboboxEditSupplierSegments.Properties.GetCheckedItems();

            string[] selectedSegments = items.ToString().Split(';');

            IsEmptyKontrol();//samet ekledi
            if (selectedSegments != null && selectedSegments.Count() != 0 && !string.IsNullOrEmpty(txtCompanyName.Text.Trim()))//samet ekledi
            {
                Supplier suplier = new Supplier();
                suplier.Address = txtAddress.Text.Trim();
                suplier.AuthorNameSurname = txtAuthorNameSurname.Text.Trim();
                suplier.CompanyName = txtCompanyName.Text.Trim();
                suplier.Email = txtEmail.Text.Trim();
                suplier.GSM = txtGSM.Text.Trim();
                suplier.IsActive = true;
                suplier.Score = txtScore.Text.Trim();
                suplier.Telephone = txtTelephone.Text.Trim();
                suplier.Country = txtCountry.Text.Trim();
                if (selectedSegments != null && selectedSegments.Count() != 0)
                {
                    suplier.Segments = new List<SupplierSegment>();
                    foreach (var item in selectedSegments)
                    {
                        suplier.Segments.Add(new SupplierSegment() { Id = int.Parse(item) });
                    }
                }
                OperationResult result = SupplierProvider.Instance.Save(suplier);
                if (result.Success)
                {
                    btnTemizle.PerformClick();
                    this.LoadGrid();
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Tedarikçi Kaydedildi...";
                    mf.ShowDialog();

                }
                else
                {
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Kayıt Sırasında Bir Hata Oluştu...";
                    mf.ShowDialog();
                }
            }
        }

        public void LoadGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            //grdSupplier.DataSource = suppliers;

            if (!string.IsNullOrEmpty(txtSearchCompanyName.Text.Trim()))
            {
                suppliers = suppliers.Where(p => p.CompanyName.Contains(txtSearchCompanyName.Text.Trim())).ToList();
            }

            if (!string.IsNullOrEmpty(txtSearchSupplierSegment.Text.Trim()))
            {
                suppliers = suppliers.Where(p => p.SupplierSegmentTexts.Contains(txtSearchSupplierSegment.Text.Trim())).ToList();
            }

            if (suppliers != null && suppliers.Count > 0)
            {
                foreach (var item in suppliers)
                {
                    if (string.IsNullOrEmpty(item.Score))
                    {
                        item.Score = "0";
                    }
                }
                suppliers = suppliers.OrderByDescending(p => double.Parse(p.Score)).ToList();
            }
            if (cmbAktivePasive.SelectedIndex == 0)
            {
                suppliers = suppliers.Where(p => p.IsActive).ToList();
                grdSupplier.DataSource = suppliers;
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                suppliers = suppliers.Where(p => !p.IsActive).ToList();
                grdSupplier.DataSource = suppliers;
                colEdit.Visible = false;
                colActive.Visible = true;
                colPasive.Visible = false;
            }
            lblRecordCount.Text = suppliers.Count.ToString();
            //if (this.FocusedRowHandle != 0)
            //{
            //    gridViewSupplier.FocusedRowHandle = this.FocusedRowHandle;
            //}

        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));

            this.FocusedRowHandle = gridViewSupplier.FocusedRowHandle;

            this.pnlKayit.Visible = false;
            this.Enabled = false;
            frm_TedarikciGuncelleme tg = new Tedarikci.frm_TedarikciGuncelleme(this);

            tg.CurrentSupplierId = id;

            tg.ShowDialog();
            pnlKayit.Visible = true;
            this.Enabled = true;
        }

        private void btnPasive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinz emin misiniz?", "Pasif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewSupplier.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
                Supplier selectedSupplier = SupplierProvider.Instance.GetItem(id);
                selectedSupplier.IsActive = false;
                SupplierProvider.Instance.Save(selectedSupplier);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void btnActive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinz emin misiniz?", "Aktif", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                this.FocusedRowHandle = gridViewSupplier.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
                Supplier selectedSupplier = SupplierProvider.Instance.GetItem(id);
                selectedSupplier.IsActive = true;
                SupplierProvider.Instance.Save(selectedSupplier);
                this.LoadGrid();
            }
            else
            {

            }
        }
        public bool IsEmptyKontrol()
        {
            object items = checkedComboboxEditSupplierSegments.Properties.GetCheckedItems();

            string[] selectedSegments = items.ToString().Split(';');

            if (selectedSegments == null || selectedSegments.Count() == 0)
            {
                dxErrorProvider1.SetError(checkedComboboxEditSupplierSegments, "Faaliyet alanı boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                dxErrorProvider1.SetError(txtCompanyName, "Firma Adı boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }

            else
            {
                dxErrorProvider1.ClearErrors();

            }
            return false;
        }
        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            checkedComboboxEditSupplierSegments.SetEditValue(null);
            txtCompanyName.Text = "";
            txtAuthorNameSurname.Text = "";
            txtCountry.Text = "";
            txtEmail.Text = "";
            txtGSM.Text = "";
            txtScore.Text = "";
            txtTelephone.Text = "";
            txtAddress.Text = "";

        }

        private void checkedComboboxEditSupplierSegments_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            txtCompanyName.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            txtSearchCompanyName.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
            txtSearchSupplierSegment.Focus();
        }

        private void txtSearchCompanyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                simpleButton3.PerformClick();
            }
        }

        private void txtSearchSupplierSegment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                simpleButton1.PerformClick();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdSupplier);
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
    }
}