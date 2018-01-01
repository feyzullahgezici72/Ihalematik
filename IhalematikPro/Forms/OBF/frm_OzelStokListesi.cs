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
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProUI.Forms;
using System.Threading;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Base;

namespace IhalematikPro.Forms
{
    public partial class frm_OzelStokListesi : IhalematikBaseForm
    {
        public int FocusedRowHandle = 0;
        public frm_OzelStokListesi()
        {
            InitializeComponent();
            base.ScreenMethod();
            LoadGrid();
        }
        public void LoadGrid()
        {
            List<OBFModel> items = UIOBFManager.Instance.GetOBFs();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                grdOBFList.DataSource = items.Where(p => p.IsActive);
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;

            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                grdOBFList.DataSource = items.Where(p => !p.IsActive);
                colEdit.Visible = false;
                colPasive.Visible = false;
                colActive.Visible = true;
            }
            //if (this.FocusedRowHandle != 0)
            //{
            //    gridViewOBFList.FocusedRowHandle = this.FocusedRowHandle;
            //}

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IsEmptyKontrol();
            OBFModel model = new OBFModel();
            model.Description = txtDescription.Text;
            model.Number = txtNumber.Text;
            model.IsActive = true;
            model.Unit = txtUnit.Text;
            model.UnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtUnitPrice.Text.Replace("TL", string.Empty));
            model.DescriptionForSupplier = txtDescriptionForSupplier.Text;
            List<OBF> existingOBFs = UIOBFManager.Instance.GetOBF(model.Number);
            if (existingOBFs != null && existingOBFs.Count != 0)
            {
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Bu OBF numarasi ile kayit bulunmaktadir";
                mf.ShowDialog();
                this.txtNumber.ResetText();
                this.txtNumber.Focus();
            }
            else
            {
                model.Save();
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Kayıt Yapıldı...";
                mf.ShowDialog();
                FormClear();
                LoadGrid();
            }
        }
        private void FormClear()
        {
            this.txtNumber.ResetText();
            this.txtDescription.ResetText();
            this.txtUnit.ResetText();
            this.txtUnitPrice.ResetText();
            this.txtNumber.Focus();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOzelStokListesi_Load(object sender, EventArgs e)
        {
            this.LoadGrid();
        }
        public bool IsEmptyKontrol()
        {
            if (string.IsNullOrEmpty(txtNumber.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtNumber, "Poz no boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtNumber, "Açıklama boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtUnit.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtUnit, "Birim boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }
            if (string.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                dxErrorProvider1.SetError(txtUnitPrice, "Birim fiyat boş bırakılamaz", DevExpress.XtraEditors.DXErrorProvider.ErrorType.User3);
                return true;
            }

            else
            {
                dxErrorProvider1.ClearErrors();
            }
            return false;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            FormClear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtDescription.ResetText();
            txtNumber.ResetText();
            txtUnit.ResetText();
            txtUnitPrice.ResetText();
            txtNumber.Focus();
        }

        private void btnGncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.FocusedRowHandle = gridViewOBFList.FocusedRowHandle;
            frm_obfGuncelle frm = new frm_obfGuncelle(this);
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOBFList.GetFocusedRowCellValue("Id"));
            frm.CurrentOBFId = id;

            pnlObfKayit.Visible = false;
            grdOBFList.Enabled = false;
            frm.ShowDialog();
            pnlObfKayit.Visible = true;
            grdOBFList.Enabled = true;
        }

        private void cmbAktivePasive_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void btnSl_Click(object sender, EventArgs e)
        {

        }

        private void frm_OzelStokListesi_Shown(object sender, EventArgs e)
        {

        }

        private void btnPasive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Pasif yapmak istediğinizden emin misiniz?", "Pasif Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewOBFList.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOBFList.GetFocusedRowCellValue("Id"));
                OBF selectedOBF = OBFProvider.Instance.GetItem(id);
                selectedOBF.IsActive = false;
                OBFProvider.Instance.Save(selectedOBF);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void btnActive_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Aktif yapmak istediğinizden emin misiniz?", "Aktif Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                this.FocusedRowHandle = gridViewOBFList.FocusedRowHandle;
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOBFList.GetFocusedRowCellValue("Id"));
                OBF selectedOBF = OBFProvider.Instance.GetItem(id);
                selectedOBF.IsActive = true;
                OBFProvider.Instance.Save(selectedOBF);
                this.LoadGrid();
            }
            else
            {

            }
        }

        private void txtDescription_EditValueChanged(object sender, EventArgs e)
        {
            txtDescriptionForSupplier.Text = txtDescription.Text;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string obfNo = txtSearchNumber.Text.Trim();
            string obfDesc = txtSearchDescription.Text.Trim();

            List<OBFModel> items = UIOBFManager.Instance.GetOBFs();

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                items = items.Where(p => p.IsActive).ToList();
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                items = items.Where(p => !p.IsActive).ToList();
            }

            if (!string.IsNullOrEmpty(obfNo))
            {
                items = items.Where(p => p.Number.Contains(obfNo)).ToList();
            }
            if (!string.IsNullOrEmpty(obfDesc))
            {
                items = items.Where(p => p.Description.Contains(obfDesc)).ToList();
            }

            grdOBFList.DataSource = null;
            grdOBFList.DataSource = items;
            lblRecordCount.Text = items.Count.ToString();
        }
    }
}