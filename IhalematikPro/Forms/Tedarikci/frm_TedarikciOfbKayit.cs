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
using IhalematikPro.Manager;
using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikciOfbKayit : DevExpress.XtraEditors.XtraForm
    {
        List<OBFModel> oBFModels = new List<OBFModel>();

        IhalematikBaseForm _owner;

        public frm_TedarikciOfbKayit(IhalematikBaseForm Owner)
        {
            InitializeComponent();
            this._owner = Owner;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string obfNo = txtNumber.Text;
            string obfDescription = txtDescription.Text;

            oBFModels = UIOBFManager.Instance.GetOBFs(obfNo, obfDescription);

            oBFModels = oBFModels.Where(p => p.IsActive).ToList();
            grdOBFList.DataSource = oBFModels;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Offer currentOffer = CurrentManager.Instance.CurrentOffer;

            int[] selectedRows = gridView1.GetSelectedRows();

            OBFModel[] selectedRowsItems = oBFModels.ToArray();

            foreach (int item in selectedRows)
            {
                OBFModel pozModel = selectedRowsItems[item];
                OfferMaterialList materialList = new OfferMaterialList();
                materialList.IsPoz = false;
                materialList.PozOBFId = pozModel.Id.Value;
                materialList.Offer = currentOffer;

                List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && !p.IsPoz).ToList();

                if (items.Count == 0)
                {
                    currentOffer.MaterialList.Add(materialList);
                }
            }

            List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(currentOffer.MaterialList.Where(p => !p.IsPoz).ToList());

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = models;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Offer currentOffer = CurrentManager.Instance.CurrentOffer;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<OfferMaterialListModel> models = gridView2.DataSource as List<OfferMaterialListModel>;

            OfferMaterialListModel[] selectedRowsItems = models.ToArray();
            currentOffer.MaterialList.ForEach(p => p.Id = p.PozOBFId);

            foreach (int item in selectedRows)
            {
                OfferMaterialListModel pozModel = selectedRowsItems[item];

                OfferMaterialList selectedItem = currentOffer.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).FirstOrDefault();

                if (selectedItem != null)
                {
                    selectedItem.IsMarkedForDeletion = true;
                    //int index = currentOffer.MaterialList.FindIndex(p => p.PozOBFId == selectedItem.PozOBFId);
                    //currentOffer.MaterialList.RemoveAt(index);
                }
            }

            List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => !p.IsPoz && !p.IsMarkedForDeletion).ToList();
            List<OfferMaterialListModel> dataSource = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(items).ToList();

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = dataSource;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Offer currentOffer = CurrentManager.Instance.CurrentOffer;
            if (currentOffer.MaterialList != null)
            {
                List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => !p.IsPoz).ToList();
                foreach (OfferMaterialList item in items)
                {
                    if (item.IsMarkedForDeletion)
                    {
                        currentOffer.MaterialList.Remove(item);
                    }
                    OfferMaterialListProvider.Instance.Save(item);
                }
            }
            if (this._owner is frm_TedarikcilereTeklifGonder)
            {
                ((frm_TedarikcilereTeklifGonder)this._owner).LoadMaterialGrid();
            }

            this.Close();
        }

        private void frm_TedarikciOfbKayit_Shown(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentOffer != null && CurrentManager.Instance.CurrentOffer.MaterialList != null)
            {
                List<OfferMaterialList> items = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => !p.IsPoz).ToList();
                List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(items).ToList();
                grdAddedOBF.DataSource = models;
            }
        }

        private void frm_TedarikciOfbKayit_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBul.PerformClick();
            }
        }
    }
}