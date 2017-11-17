using System;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using System.Collections.Generic;
using IhalematikProUI.Model;
using IhalematikPro.Model;
using System.Linq;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikcilereTeklifGonder : IhalematikBaseForm
    {
        public frm_TedarikcilereTeklifGonder()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPozKayit_Click(object sender, EventArgs e)
        {
            frm_TedarikciPozluKayit poz = new frm_TedarikciPozluKayit(this);
            poz.ShowDialog();
        }

        private void frm_TedarikcilereTeklifGonder_Shown(object sender, EventArgs e)
        {
            this.LoadMaterialGrid();
            this.LoadSupplierGrid();
        }

        public void LoadSupplierGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
        }
        public void LoadMaterialGrid(List<OfferMaterialListModel> Items = null)
        {
            if (Items == null)
            {
                List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => !p.IsSelected).ToList());
                grdMaterialList.DataSource = models;
            }
            else
            {
                grdMaterialList.DataSource = Items.Where(p => !p.IsSelected);
            }

        }
        private void btnObfKayit_Click(object sender, EventArgs e)
        {
            frm_TedarikciOfbKayit obf = new frm_TedarikciOfbKayit(this);
            obf.ShowDialog();
        }

        private void gridViewMaterialList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colQuantity)
            {
                int Id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("Id"));
                if (CurrentManager.Instance.CurrentOffer.MaterialList != null)
                {
                    foreach (OfferMaterialList offerMaterialList in CurrentManager.Instance.CurrentOffer.MaterialList)
                    {
                        if (offerMaterialList.Id == Id)
                        {
                            offerMaterialList.Quantity = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(e.Value);
                            OfferMaterialListProvider.Instance.Save(offerMaterialList);
                        }
                    }
                }
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            List<OfferMaterialListModel> datasourceMaterialList = gridViewMaterialList.DataSource as List<OfferMaterialListModel>;
            List<SupplierModel> dataSoruceSupplier = gridViewSupplier.DataSource as List<SupplierModel>;

            if (datasourceMaterialList != null && dataSoruceSupplier != null)
            {
                List<OfferMaterialListModel> seledtedMaterialLists = datasourceMaterialList.Where(p => p.IsSelected).ToList();
                List<SupplierModel> seledtedSuppliers = dataSoruceSupplier.Where(p => p.IsSelected).ToList();
                if (seledtedSuppliers.Count != 0 && seledtedMaterialLists.Count != 0)
                {
                    foreach (OfferMaterialListModel seledtedMaterialList in seledtedMaterialLists)
                    {
                        OfferMaterialList items = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Id == seledtedMaterialList.Id).FirstOrDefault();
                        items.IsSelected = true;
                        foreach (var seledtedSupplier in seledtedSuppliers)
                        {
                            SupplierMaterialList supplierMaterialList = new SupplierMaterialList();
                            supplierMaterialList.Offer = CurrentManager.Instance.CurrentOffer;
                            supplierMaterialList.SupplierId = seledtedSupplier.Id.Value;
                            supplierMaterialList.MaterialListId = seledtedMaterialList.Id.Value;
                            Dictionary<string, object> parameters = new Dictionary<string, object>();
                            parameters.Add("OfferId", supplierMaterialList.OfferId);
                            parameters.Add("SupplierId", supplierMaterialList.SupplierId);
                            parameters.Add("MaterialListId", supplierMaterialList.MaterialListId);

                            List<SupplierMaterialList> existingItems = SupplierMaterialListProvider.Instance.GetItems(parameters);

                            if (existingItems.Count == 0)
                            {
                                SupplierMaterialListProvider.Instance.Save(supplierMaterialList);
                            }
                        }
                    }
                    this.LoadMaterialGrid(datasourceMaterialList);
                }
            }
        }
    }
}