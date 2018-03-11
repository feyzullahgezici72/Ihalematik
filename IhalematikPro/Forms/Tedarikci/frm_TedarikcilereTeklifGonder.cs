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
        public int FocusedRowHandle { get; private set; }

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
            grdMaterialList.TabIndex = 0; //samet
            grdSupplier.TabIndex = 0;//samet
            if (CurrentManager.Instance.CurrentOffer != null)
            {
                lblOfferDescription.Text = CurrentManager.Instance.CurrentOffer.Description;
                lblTenderNumber.Text = CurrentManager.Instance.CurrentOffer.Number;
            }
            colChangeMetreialName.Visible = true;
            pnlx.Visible = true;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            pnlMalzemeListesi.Enabled = true;
            pnlUst.Enabled = true;
            pnlFirma.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            this.LoadMaterialGrid();
        }

        public void LoadSupplierGrid()
        {
            List<Supplier> suppliers = SupplierProvider.Instance.GetItems();
            suppliers = suppliers.Where(p => p.IsActive).ToList();
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
        }

        //Malzeme eklenen Tedarikciler
        public void LoadAddedMaterialSupplierGrid()
        {
            List<Supplier> suppliers = CurrentManager.Instance.CurrentOffer.Suppliers;
            List<SupplierModel> models = IhalematikModelBase.GetModels<SupplierModel, Supplier>(suppliers);
            grdSupplier.DataSource = models;
        }

        public void LoadMaterialGrid(List<OfferMaterialList> Items = null)
        {
            if (Items == null)
            {
                colIsSelectedOfferMaterial.Visible = false;
                if (CurrentManager.Instance.CurrentOffer != null)
                {
                    List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(CurrentManager.Instance.CurrentOffer.MaterialList.ToList());
                    grdMaterialList.DataSource = models;
                }
            }
            else
            {
                List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(Items);
                colIsSelectedOfferMaterial.Visible = true;
                grdMaterialList.DataSource = models.Where(p => !p.IsSelected).ToList();
            }
            if (this.FocusedRowHandle != 0)
            {
                gridViewMaterialList.FocusedRowHandle = this.FocusedRowHandle;
            }

        }
        private void btnObfKayit_Click(object sender, EventArgs e)
        {
            frm_TedarikciOfbKayit obf = new frm_TedarikciOfbKayit(this);
            obf.ShowDialog();
        }

        private void gridViewMaterialList_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colMaterialListQuantity)
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

            if (dataSoruceSupplier == null)
            {
                MessageBox.Show(" Aktif yada tanımlı tedarikçi bulunamadı.");
                return;
            }

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
                    frm_MesajFormu mf = new frm_MesajFormu();
                    mf.lblMesaj.Text = "Seçili Malzemeler Firmaya aktarıldı...";
                    mf.ShowDialog();
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
            colBirimFiyat.Visible = false;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            colMaterialListQuantity.OptionsColumn.AllowEdit = true;
            colMaterialListQuantity.OptionsColumn.AllowFocus = true;
            colMaterialListQuantity.OptionsColumn.ReadOnly = false;
            colChangeMetreialName.Visible = true;
            this.LoadMaterialGrid();
        }

        private void btnTedaikcileregonder_Click(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentOffer == null)
            {
                return;
            }
            int quantityZeroCount = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Quantity == 0).Count();

            if (quantityZeroCount > 0)
            {
                //todo feyzullahg
                MessageBox.Show("Miktari sifir olan malzeme olmamali...");
                return;
            }

            this.LoadSupplierGrid();
            this.LoadMaterialGrid(CurrentManager.Instance.CurrentOffer.MaterialList.ToList());
            colMaterialListQuantity.OptionsColumn.AllowEdit = false;
            colMaterialListQuantity.OptionsColumn.AllowFocus = false;
            colMaterialListQuantity.OptionsColumn.ReadOnly = false;
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
            colChangeMetreialName.Visible = false;
            this.ShowMailPanel = false;
        }

        private void btnTedarikciListesi_Click(object sender, EventArgs e)
        {
            int quantityZeroCount = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Quantity == 0).Count();

            if (quantityZeroCount > 0)
            {
                //todo feyzullahg
                MessageBox.Show("Miktari sifir olan malzeme olmamali...");
                return;
            }
            this.LoadAddedMaterialSupplierGrid();
            colMaterialListQuantity.OptionsColumn.AllowEdit = false;
            colMaterialListQuantity.OptionsColumn.AllowFocus = false;
            colMaterialListQuantity.OptionsColumn.ReadOnly = false;
            pnlGonderilecekListe.Visible = false;
            pnlobfpozButtonpanel.Visible = false;
            pnlMalzemeListesi.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlFirma.Visible = true;
            pnlFirma.Dock = DockStyle.Fill;
            pnlFirma.BringToFront();
            colIsSelectedSupplier.Visible = false;
            colSupplierDetail.Visible = true;
            colChangeMetreialName.Visible = false;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {


        }

        private void frm_TedarikcilereTeklifGonder_Load(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void btnChangeMeterialName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_MalzemeAdlandir frm = new frm_MalzemeAdlandir(this);

            int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialList.GetFocusedRowCellValue("PozOBFId"));
            bool IsPoz = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<bool>(gridViewMaterialList.GetFocusedRowCellValue("IsPoz"));

            this.FocusedRowHandle = gridViewMaterialList.FocusedRowHandle;

            frm.currentPozOBFId = id;
            frm.IsPoz = IsPoz;
            frm.ShowDialog();
        }

        private void btnTumunuAktar_Click(object sender, EventArgs e)
        {
            List<OfferMaterialListModel> datasourceMaterialList = gridViewMaterialList.DataSource as List<OfferMaterialListModel>;

            foreach (var seledtedMaterialList in datasourceMaterialList)
            {
                seledtedMaterialList.IsSelected = true;
                OfferMaterialList items = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Id == seledtedMaterialList.Id).FirstOrDefault();
                items.IsSelected = true;
                //OfferMaterialListProvider.Instance.Save(items);
            }
            grdMaterialList.DataSource = null;
            grdMaterialList.DataSource = datasourceMaterialList;
            //grdMaterialList.RefreshDataSource();
        }
    }
}