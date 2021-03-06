﻿using System;
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
using IhalematikProUI.Forms.OBF;
using System.Globalization;
using IhalematikProUI.Forms.Genel;
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProBL.Manager;
using IhalematikProBL.Enum;

namespace IhalematikPro.Forms
{
    public partial class frm_OzelStokListesi : IhalematikBaseForm
    {
        public int FocusedRowHandle = 0;
        public frm_OzelStokListesi()
        {
            InitializeComponent();
            base.ScreenMethod();

        }
        public void LoadGrid()
        {
            //LoadingManager.Instance.Show(this);
            List<OBFModel> allItems = UIOBFManager.Instance.GetOBFs();
            List<OBFModel> items = new List<OBFModel>();

            foreach (var item in allItems)
            {
                if (item.Childrens.Count == 0)
                {
                    items.Add(item);
                }
                else
                {
                    items.Add(item.Childrens.OrderByDescending(p => p.InserTime).FirstOrDefault());
                }
            }

            if (cmbAktivePasive.SelectedIndex == 0)
            {
                items = items.Where(p => p.IsActive).ToList();
                colPasive.Visible = true;
                colEdit.Visible = true;
                colActive.Visible = false;
            }
            else if (cmbAktivePasive.SelectedIndex == 1)
            {
                items = items.Where(p => !p.IsActive).ToList();
                colEdit.Visible = false;
                colPasive.Visible = false;
                colActive.Visible = true;
            }
            //LoadingManager.Instance.Hide();
            grdOBFList.DataSource = items;
            lblRecordCount.Text = items.Count.ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bool isEmpty = IsEmptyKontrol();
            if (isEmpty)
            {
                return;
            }
            OBFModel model = new OBFModel();
            model.Description = txtDescription.Text;
            int lastTenderNumber = UIOBFManager.Instance.GetLastOBFNumber();
            model.Number = (lastTenderNumber + 1).ToString();
            model.IsActive = true;
            model.StokNumber = txtNumber.Text;
            model.Unit = txtUnit.Text;
            //model.UnitPrice = double.Parse(txtUnitPrice.Text.Replace("TL", string.Empty), CultureInfo.InvariantCulture);
            model.UnitPrice = model.UnitPrice = double.Parse(txtUnitPrice.Text.Replace("TL", string.Empty));
            model.CurrencyType = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<CurrencyTypesEnum>(ddlCurrencyType.SelectedIndex);
            model.DescriptionForSupplier = txtDescriptionForSupplier.Text;

            List<OBFModel> existingOBFs = UIOBFManager.Instance.GetOBFs(model.Description);
            if (existingOBFs != null && existingOBFs.Count != 0)
            {
                frm_MesajFormu mf = new frm_MesajFormu();
                mf.lblMesaj.Text = "Bu OBF açıklaması ile kayit bulunmaktadir";
                mf.ShowDialog();
                this.txtNumber.Text = "";
                this.txtNumber.Focus();
            }
            else
            {
                model.Save();
                //frm_MesajFormu mf = new frm_MesajFormu();
                //mf.lblMesaj.Text = "Kayıt Yapıldı...";
                //mf.ShowDialog();
                UIPopupManager.Instance.ShowPopup();
                FormClear();
                LoadGrid();
            }
        }
        private void FormClear()
        {
            this.txtNumber.Text = "";
            this.txtDescription.Text = "";
            this.txtUnit.Text = "";
            this.txtUnitPrice.Text = "";
            this.txtNumber.Focus();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOzelStokListesi_Load(object sender, EventArgs e)
        {
            //this.LoadGrid();
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
            txtDescription.Text = "";
            txtNumber.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            txtNumber.Focus();
        }

        private void btnGncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.FocusedRowHandle = gridViewOBFList.FocusedRowHandle;
            frm_obfGuncelle frm = new frm_obfGuncelle(this);
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOBFList.GetFocusedRowCellValue("Id"));
            frm.CurrentOBFId = id;

            //pnlObfKayit.Visible = false;
            grdOBFList.Enabled = false;
            frm.ShowDialog();
            //pnlObfKayit.Visible = true;
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
            this.Enabled = false;
            this.LoadGrid();
            this.Enabled = true;
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
            this.SearchResult();
            txtSearchDescription.Focus();
        }

        private void SearchResult()
        {
            string obfNo = txtSearchNumber.Text.Trim();
            string obfDesc = txtSearchDescription.Text.Trim();

            List<OBFModel> allItems = UIOBFManager.Instance.GetOBFs();
            List<OBFModel> items = new List<OBFModel>();

            foreach (var item in allItems)
            {
                if (item.Childrens.Count == 0)
                {
                    items.Add(item);
                }
                else
                {
                    items.Add(item.Childrens.OrderByDescending(p => p.InserTime).FirstOrDefault());
                }
            }

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
                items = items.Where(p => p.StokNumber.ToLower().Contains(obfNo.ToLower())).ToList();
            }
            if (!string.IsNullOrEmpty(obfDesc))
            {
                items = items.Where(p => p.Description.ToLower().Contains(obfDesc.ToLower())).ToList();
            }

            grdOBFList.DataSource = null;
            grdOBFList.DataSource = items;
            lblRecordCount.Text = items.Count.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frm_TopluOBFekle toe = new frm_TopluOBFekle(this);
            toe.ShowDialog();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.SearchResult();
            txtSearchNumber.Focus();
        }

        private void txtSearchNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton3.PerformClick();
            }
        }

        private void txtSearchDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                simpleButton1.PerformClick();

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdOBFList);
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

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUnit.Focus();
            }
        }
    }
}