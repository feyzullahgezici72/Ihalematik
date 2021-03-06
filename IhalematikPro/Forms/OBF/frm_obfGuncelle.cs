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
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Forms;
using IhalematikPro.Model;
using System.Globalization;
using IhalematikPro.Manager;
using IhalematikProBL.Enum;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_obfGuncelle : DevExpress.XtraEditors.XtraForm
    {
        frm_OzelStokListesi _owner = null;
        public int CurrentOBFId { get; set; }
        public IhalematikProBL.Entity.OBF currentOBF { get; set; }
        public IhalematikProBL.Entity.OBF CurrentOBF
        {
            get
            {
                if (this.currentOBF == null)
                {
                    this.currentOBF = OBFProvider.Instance.GetItem(this.CurrentOBFId);
                }
                return this.currentOBF;
            }
        }
        public frm_obfGuncelle(frm_OzelStokListesi Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this._owner.LoadGrid();
        }
        private void frm_obfGuncelle_Load(object sender, EventArgs e)
        {
            if (this.CurrentOBF != null)
            {
                txtDescription.Text = this.CurrentOBF.Description;
                txtNumber.Text = this.CurrentOBF.StokNumber;
                txtUnit.Text = this.CurrentOBF.Unit;
                //var cultureInfo = new System.Globalization.CultureInfo("tr-TR");
                txtUnitPrice.Text = this.CurrentOBF.UnitPrice.ToString();
                txtDescriptionForSupplier.Text = this.CurrentOBF.DescriptionForSupplier;
            }
            txtDescriptionForSupplier.Text = txtDescription.Text;
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
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            IsEmptyKontrol();
            if (this.CurrentOBF != null)
            {
                OBFModel model = new OBFModel(this.currentOBF);
                model.Description = txtDescription.Text;
                model.StokNumber = txtNumber.Text;
                model.Unit = txtUnit.Text;
                double newUnitPrice = double.Parse(txtUnitPrice.Text.Replace("TL", string.Empty));
                model.DescriptionForSupplier = txtDescriptionForSupplier.Text;

                //List<OBFModel> existingOBFs = UIOBFManager.Instance.GetOBFs(model.Description);
                //if (existingOBFs != null && existingOBFs.Count != 0 && existingOBFs.First().Id !+model.Id)
                //{
                //    frm_MesajFormu mf = new frm_MesajFormu();
                //    mf.lblMesaj.Text = "Bu OBF açıklaması ile kayit bulunmaktadir";
                //    mf.ShowDialog();
                //    this.txtNumber.Text = "";
                //    this.txtNumber.Focus();
                //}
                //else
                //{
                model.Save();
                if (!this.CurrentOBF.UnitPrice.Equals(newUnitPrice))
                {
                    //OBFModel newObf = new OBFModel();
                    //newObf.IsActive = true;
                    if (model.ParentId == 0)
                    {
                        model.ParentId = model.Id.Value;
                    }
                    model.UnitPrice = newUnitPrice;
                    model.CurrencyType = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<CurrencyTypesEnum>(ddlCurrencyType.SelectedIndex);
                    model.Id = 0;
                    model.Save();
                }

                //frm_MesajFormu mf = new frm_MesajFormu();
                //mf.lblMesaj.Text = "Kayıt Güncellendi...";
                //mf.ShowDialog();
                UIPopupManager.Instance.ShowPopup();
                this._owner.LoadGrid();
                this.Close();
                //}
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtUnit.Focus();
            }
        }

        private void ddlCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}