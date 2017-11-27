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
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Entity;
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using System.IO;
using ExcelDataReader;

namespace IhalematikProUI.Forms
{
    public partial class frm_TedarikcilerdenFiyatAl : IhalematikBaseForm
    {
        public frm_TedarikcilerdenFiyatAl()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void frm_TedarikcilerdenFiyatAl_Shown(object sender, EventArgs e)
        {
            this.LoadSupplierGrid();
        }
        public void LoadSupplierGrid()
        {
            List<Supplier> suppliers = CurrentManager.Instance.CurrentOffer.Suppliers;
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
            this.gridViewSupplier_RowClick(null, null);
        }

        private void gridViewSupplier_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            colSuppierName.Visible = false;
            int supplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
            parameters.Add("SupplierId", supplierId);
            List<SupplierMaterialList> supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(parameters);

            List<OfferMaterialListModel> models = new List<OfferMaterialListModel>();
            if (supplierMaterialList.Count != 0)
            {
                foreach (var item in supplierMaterialList)
                {
                    OfferMaterialListModel model = new OfferMaterialListModel(item.MaterialList);
                    model.Price = item.Price;
                    models.Add(model);
                }
            }
            grdMaterialList.DataSource = models;
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<OfferMaterialListModel> dataSoruce = new List<OfferMaterialListModel>();

            if (rdSortPrice.SelectedIndex == 0)
            {
                List<SupplierMaterialList> supplierMaterialLists = SupplierMaterialListProvider.Instance.GetItems("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                var groupedMaterial = supplierMaterialLists.GroupBy(p => p.MaterialListId);

                foreach (var item in groupedMaterial)
                {
                    SupplierMaterialList supplierMaterialList = item.Where(p => p.Price != 0).OrderBy(p => p.Price).First();

                    OfferMaterialListModel model = new OfferMaterialListModel(supplierMaterialList.MaterialList);
                    model.Price = supplierMaterialList.Price;
                    model.SupplierName = supplierMaterialList.Supplier.CompanyName;
                    dataSoruce.Add(model);
                }
            }
            else if (rdSortPrice.SelectedIndex == 1)
            {
                List<SupplierMaterialList> supplierMaterialLists = SupplierMaterialListProvider.Instance.GetItems("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                var groupedMaterial = supplierMaterialLists.GroupBy(p => p.MaterialListId);

                foreach (var item in groupedMaterial)
                {
                    List<SupplierMaterialList> items = item.Where(p => p.Price != 0).OrderBy(p => p.Price).ToList();
                    SupplierMaterialList supplierMaterialList = new SupplierMaterialList();

                    if (items.Count < 3)
                    {
                        supplierMaterialList = items.First();
                    }
                    else
                    {
                        double count = items.Count;
                        count = (items.Count / 2) - 1;
                        supplierMaterialList = items.ToArray()[(int)Math.Round(count)];
                    }
                    OfferMaterialListModel model = new OfferMaterialListModel(supplierMaterialList.MaterialList);
                    model.Price = supplierMaterialList.Price;
                    model.SupplierName = supplierMaterialList.Supplier.CompanyName;
                    dataSoruce.Add(model);

                }
            }
            grdMaterialList.DataSource = dataSoruce;
            colSuppierName.Visible = true;
        }
    }
}