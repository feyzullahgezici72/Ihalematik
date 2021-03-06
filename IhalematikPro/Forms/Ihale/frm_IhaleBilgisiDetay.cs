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
using SimpleApplicationBase.BL.Base;
using IhalematikPro.Forms;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Forms
{
    public partial class frm_IhaleBilgisiDetay : DevExpress.XtraEditors.XtraForm
    {
        public int SelectedOfferId { get; set; }
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
        private frm_DevamEdenIhaleListesi _owner = null;
        public frm_IhaleBilgisiDetay(frm_DevamEdenIhaleListesi Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadGridOffer()
        {
            List<Offer> offers = OfferProvider.Instance.GetItems();
            //offers.Where(p=> p.)
            grdOffer.DataSource = offers.Where(p => p.IsCompleated && p.IsActive).ToList();
        }
        private void frm_IhaleBilgisiDetay_Load(object sender, EventArgs e)
        {
            txtTeklifNo.Text = this.Tender.DisplayNumber.ToString();
            txtAciklama.Text = this.Tender.Description;
            LastOfferDate.DateTime = this.Tender.LastOfferDate.Value;
            txtcompanyName.Text = this.Tender.CompanyName;
            txtEkapNumber.Text = this.Tender.EkapNumber;
            txtType.Text = this.Tender.Type;
            txtScope.Text = this.Tender.Scope;
            txtProcedure.Text = this.Tender.Procedure;
            txtPlace.Text = this.Tender.Place;
            txtManagement.Text = this.Tender.Management;
            ddlTenderType.SelectedIndex = (int)this.Tender.TenderType;

            if (this.Tender.MaterialList == null || this.Tender.MaterialList.Count == 0 )
            {
                grdOffer.Enabled = true;
            }
            else
            {
                grdOffer.Enabled = false;
            }
            this.LoadGridOffer();
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
                this.Tender.OfferId = this.SelectedOfferId;
                this.Tender.Scope = txtScope.Text;
                this.Tender.Procedure = txtProcedure.Text;
                this.Tender.Place = txtPlace.Text;
                this.Tender.Management = txtManagement.Text;
                if (ddlTenderType.SelectedIndex == 0)
                {
                    this.Tender.TenderType = IhalematikProBL.Enum.TenderTypeEnum.Open;
                }
                else if (ddlTenderType.SelectedIndex == 1)
                {
                    this.Tender.TenderType = IhalematikProBL.Enum.TenderTypeEnum.DirectSupply;
                }
                OperationResult res = TenderProvider.Instance.Save(this.Tender);
                if (res.Success)
                {
                    //MessageBox.Show("Ihale bilgileri güncellendi.");
                    this._owner.LoadGrid();
                    UIPopupManager.Instance.ShowPopup();
                }
                else
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu.");
                }
                this.Close();
            }
        }

        private void gridViewOffer_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridViewOffer.RowCount; i++)
            {
                gridViewOffer.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewOffer.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedOfferId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
        }

        private void rpstSelected_CheckedChanged(object sender, EventArgs e)
        {
            bool isSelected = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<bool>(gridViewOffer.GetFocusedRowCellValue("IsSelected"));
            for (int i = 0; i < gridViewOffer.RowCount; i++)
            {
                gridViewOffer.SetRowCellValue(i, colIsSelected, false);
            }

            if (isSelected)
            {
                gridViewOffer.SetFocusedRowCellValue(colIsSelected, false);
                this.SelectedOfferId = 0;
            }
            else
            {
                gridViewOffer.SetFocusedRowCellValue(colIsSelected, true);
                this.SelectedOfferId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewOffer.GetFocusedRowCellValue("Id"));
            }
        }
    }
}