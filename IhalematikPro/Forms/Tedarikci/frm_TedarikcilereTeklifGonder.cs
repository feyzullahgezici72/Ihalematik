using System;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using System.Collections.Generic;
using IhalematikProUI.Model;
using IhalematikPro.Model;
using System.Linq;
using IhalematikPro.Forms;
using System.Windows.Forms;
using IhalematikProBL.Manager;
using ExcelDataReader;
using System.IO;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikcilereTeklifGonder : IhalematikBaseForm
    {
        public bool ShowMailPanel { get; set; }
        public frm_TedarikcilereTeklifGonder()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void btnPozKayit_Click(object sender, EventArgs e)
        {
            frm_TedarikciPozluKayit poz = new frm_TedarikciPozluKayit(this);
            poz.ShowDialog();
        }

        private void frm_TedarikcilereTeklifGonder_Shown(object sender, EventArgs e)
        {
            lblOfferDescription.Text = CurrentManager.Instance.CurrentOffer.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentOffer.Number;
            pnlx.Visible = true;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            pnlMalzemeListesi.Enabled = true;
            pnlUst.Enabled = true;
            pnlFirma.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            this.LoadMaterialGrid();
            this.LoadSupplierGrid();
        }

        public void LoadSupplierGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
        }
        public void LoadMaterialGrid(List<OfferMaterialList> Items = null)
        {
            if (Items == null)
            {
                colIsSelectedOfferMaterial.Visible = false;
                List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(CurrentManager.Instance.CurrentOffer.MaterialList.ToList());
                grdMaterialList.DataSource = models;
            }
            else
            {
                List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(Items);
                colIsSelectedOfferMaterial.Visible = true;
                grdMaterialList.DataSource = models.Where(p => !p.IsSelected).ToList();
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
                        OfferMaterialListProvider.Instance.Save(items);
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
                    this.LoadMaterialGrid(CurrentManager.Instance.CurrentOffer.MaterialList.ToList());
                }
            }
        }

        private void btnListeOlustur_Click(object sender, EventArgs e)
        {
            pnlGonderilecekListe.Visible = false;
            pnlobfpozButtonpanel.Visible = true;
            pnlMalzemeListesi.Visible = true;
            pnlUst.Enabled = true;
            pnlFirma.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
        }

        private void btnTedaikcileregonder_Click(object sender, EventArgs e)
        {
            pnlGonderilecekListe.Visible = true;
            pnlobfpozButtonpanel.Visible = false;
            pnlMalzemeListesi.Visible = true;
            pnlFirma.Visible = true;
            pnlAktarmaPaneli.Visible = true;
            pnlFirma.Dock = DockStyle.None;
            pnlFirma.Dock = DockStyle.Right;
            pnlFirma.BringToFront();
            pnlAktarmaPaneli.Dock = DockStyle.Right;
            pnlAktarmaPaneli.BringToFront();
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            pnlMalzemeListesi.BringToFront();
            colIsSelectedSupplier.Visible = true;
            this.ShowMailPanel = false;
            this.LoadMaterialGrid(CurrentManager.Instance.CurrentOffer.MaterialList.ToList());
        }

        private void btnTedarikciListesi_Click(object sender, EventArgs e)
        {
            pnlGonderilecekListe.Visible = false;
            pnlobfpozButtonpanel.Visible = false;
            pnlMalzemeListesi.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlFirma.Visible = true;
            pnlFirma.Dock = DockStyle.Fill;
            pnlFirma.BringToFront();
            colIsSelectedSupplier.Visible = false;
            colSupplierDetail.Visible = true;
            this.ShowMailPanel = true;
        }

        private void btnGonderilenMalzemeListesi_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            frm_GonderilecekMalzemeListesi gml = new frm_GonderilecekMalzemeListesi(this);
            gml.ShowDialog();
            this.Enabled = true;
        }

        private void rpstSupplierDetail_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.Enabled = false;
            frm_TedarikciyeAktarilanMalzemeDetay md = new frm_TedarikciyeAktarilanMalzemeDetay(this);
            md.ShowMailPanel = this.ShowMailPanel;
            int selectedSupplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            md.SelectedSupplierId = selectedSupplierId;
            md.ShowDialog();
            this.Enabled = true;
        }
    }
}