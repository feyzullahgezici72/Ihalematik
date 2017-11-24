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
                frm_FaalitetAlaniEkle frm = new frm_FaalitetAlaniEkle();
                frm.ShowDialog();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_FaalitetAlaniEkle FAE = new frm_FaalitetAlaniEkle();
            FAE.ShowDialog();
        }

        private void grdWorker_Click(object sender, EventArgs e)
        {

        }

        private void frm_TedarikciTanimlama_Shown(object sender, EventArgs e)
        {
            List<SupplierSegment> supplierSegments = SupplierSegmentProvider.Instance.GetItems();
            ddlSegments.Properties.Items.AddRange(supplierSegments);
            this.LoadGrid();
            //comboBox1.DataSource = supplierSegments;
            //checkedComboBoxEdit1.Properties.Items.AddRange(supplierSegments);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
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

            OperationResult result = SupplierProvider.Instance.Save(suplier);
            if (result.Success)
            {
                MessageBox.Show("Kaydedildi");
                this.LoadGrid();
            }
            else
            {
                MessageBox.Show("Kayit sirasinda hata olustu");
            }
        }

        public void LoadGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            //grdSupplier.DataSource = suppliers;

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdSupplier.DataSource = suppliers.Where(p => p.IsActive);
                colEdit.Visible = true;
                colActive.Visible = false;
                colPasive.Visible = true;

            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdSupplier.DataSource = suppliers.Where(p => !p.IsActive);
                colEdit.Visible = true;
                colActive.Visible = true;
                colPasive.Visible = false;
            }

            if (this.FocusedRowHandle != 0)
            {
                gridViewSupplier.FocusedRowHandle = this.FocusedRowHandle;
            }
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

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }
    }
}