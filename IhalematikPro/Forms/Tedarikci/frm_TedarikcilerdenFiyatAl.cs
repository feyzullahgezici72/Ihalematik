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
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Entity;
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikPro.Forms;
using System.IO;
using ExcelDataReader;
using IhalematikProUI.Forms.Tedarikci;

namespace IhalematikProUI.Forms
{
    public partial class frm_TedarikcilerdenFiyatAl : IhalematikBaseForm
    {
        public frm_TedarikcilerdenFiyatAl()
        {
            InitializeComponent();
            base.ScreenMethod();
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
            pnlrisk.Visible = false;
            pnltoplam.Visible = false;
            btnKaydet.Visible = false;
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
            colRisk.Visible = false;
            colPriceWithRisk.Visible = false;
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
                    if (item.Price != 0)
                    {
                        OfferMaterialListModel model = new OfferMaterialListModel(item.MaterialList);
                        model.Price = item.Price;
                        model.KDV = item.KDV;
                        model.Risk = item.Risk;
                        model.SupplierMaterialList = item;
                        model.SupplierMaterialListId = item.Id;
                        models.Add(model);
                    }
                }
            }
            grdMaterialList.DataSource = models;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //colRisk.Visible = true;
            //colPriceWithRisk.Visible = true;
            btnKaydet.Visible = true;
            //pnlrisk.Visible = true;
            pnltoplam.Visible = true;
            List<OfferMaterialListModel> dataSoruce = new List<OfferMaterialListModel>();

            if (rdSortPrice.SelectedIndex == 0)
            {
                List<SupplierMaterialList> supplierMaterialLists = SupplierMaterialListProvider.Instance.GetItems("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                var groupedMaterial = supplierMaterialLists.GroupBy(p => p.MaterialListId);

                foreach (var item in groupedMaterial)
                {
                    SupplierMaterialList supplierMaterialList = item.Where(p => p.Price != 0).OrderBy(p => p.Price).FirstOrDefault();

                    if (supplierMaterialList == null)
                    {
                        supplierMaterialList = item.First();
                    }
                    if (supplierMaterialList.Price != 0)
                    {
                        OfferMaterialListModel model = new OfferMaterialListModel(supplierMaterialList.MaterialList);
                        model.KDV = supplierMaterialList.KDV;
                        model.Price = supplierMaterialList.Price;
                        model.SupplierName = supplierMaterialList.Supplier.CompanyName;
                        model.SupplierMaterialList = supplierMaterialList;
                        model.SupplierMaterialListId = supplierMaterialList.Id;
                        model.Risk = supplierMaterialList.Risk;
                        dataSoruce.Add(model); 
                    }
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

                    if (items.Count == 0)
                    {
                        supplierMaterialList = item.FirstOrDefault();
                    }
                    else if (items.Count < 3)
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
                    model.SupplierMaterialListId = supplierMaterialList.Id;
                    model.KDV = supplierMaterialList.KDV;
                    model.Risk = supplierMaterialList.Risk;
                    model.SupplierMaterialList = supplierMaterialList;
                    model.Price = supplierMaterialList.Price;
                    model.SupplierName = supplierMaterialList.Supplier.CompanyName;
                    dataSoruce.Add(model);

                }
            }
            grdMaterialList.DataSource = dataSoruce;
            this.CalculateInnerValues();
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            List<OfferMaterialListModel> items = grdMaterialList.DataSource as List<OfferMaterialListModel>;
            double risk = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRisk.Text);

            foreach (var item in items)
            {
                item.Risk = risk;
                SupplierMaterialList supplierMaterialList = item.SupplierMaterialList;
                supplierMaterialList.Risk = risk;
                SupplierMaterialListProvider.Instance.Save(supplierMaterialList);
            }
            this.simpleButton1_Click(null, null);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colRisk)
            {
                int SupplierMaterialListId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("SupplierMaterialListId"));
                SupplierMaterialList item = SupplierMaterialListProvider.Instance.GetItem(SupplierMaterialListId);
                item.Risk = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                SupplierMaterialListProvider.Instance.Save(item);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<OfferMaterialListModel> items = grdMaterialList.DataSource as List<OfferMaterialListModel>;

            if (items != null)
            {
                SupplierMaterialListProvider.Instance.SupplierMaterialListSelectedUpdate(CurrentManager.Instance.CurrentOffer.Id);

                foreach (var item in items)
                {
                    SupplierMaterialList supplierMaterialList = item.SupplierMaterialList;
                    supplierMaterialList.IsSelected = true;
                    SupplierMaterialListProvider.Instance.Save(supplierMaterialList);
                }
                frm_MesajFormu mesajform = new frm_MesajFormu();
                mesajform.lblMesaj.Text = "Teklif Kaydedildi...";
                mesajform.ShowDialog();

                CurrentManager.Instance.CurrentOffer.IsCompleated = true;
                OfferProvider.Instance.Save(CurrentManager.Instance.CurrentOffer);
            }
        }

        private void rpstSupplierDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.Enabled = false;
            //Kuzen bu bağlantıyı yaparsın
            //frm_TedarikciyeAktarilanMalzemeDetay tkfmd = new frm_TedarikciyeAktarilanMalzemeDetay();
            this.Enabled = true;
        }

        private void rpstMeterialDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Malzemeye hangi firma hangi fiyatı vermiş
            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("Id"));
            this.Enabled = false;
            frm_MalzemeBazindaTedarikciFiyatDetay mbtfd = new frm_MalzemeBazindaTedarikciFiyatDetay();
            mbtfd.SelectedOfferMaterialListId = id;
            mbtfd.ShowDialog();
            this.Enabled = true;
        }

        private void grdSupplier_Click(object sender, EventArgs e)
        {
            pnlrisk.Visible = false;
            pnltoplam.Visible = false;
            btnKaydet.Visible = false;
        }

        private void CalculateInnerValues()
        {
            List<OfferMaterialListModel> dataSoruce = grdMaterialList.DataSource as List<OfferMaterialListModel>;

            double baseAmount = Math.Round(dataSoruce.Sum(p => p.PriceWithRisk * p.Quantity), 2);
            double baseKDVamount = Math.Round(dataSoruce.Sum(p => p.PriceWithRisk * p.Quantity * p.KDV / 100), 2); ;
            txtBaseAmount.Text = baseAmount.ToString("c2");
            txtBaseKDVAmount.Text = baseKDVamount.ToString("c2");
            txtTotalAmount.Text = (baseKDVamount + baseAmount).ToString("c2");
        }

        private void rdSortPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlrisk.Visible = false;
            pnltoplam.Visible = false;
            btnKaydet.Visible = false;
        }

        private void txtRisk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTumuneUygula.PerformClick();
            }
        }
    }
}