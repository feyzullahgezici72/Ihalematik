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
            pnlx.Visible = true;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            pnlMalzemeListesi.Enabled = true;
            pnlUst.Enabled = true;
            pnlFirma.Visible = false;
            pnlAktarilanlar.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            this.LoadMaterialGrid();
            this.LoadSupplierGrid();
            this.LoadAddedMateriallistGrid();
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
                grdMaterialList.DataSource = Items.Where(p => !p.IsSelected).ToList();
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
                    this.LoadAddedMateriallistGrid();
                }
            }
        }

        private void LoadAddedMateriallistGrid()
        {
            grdAddedOfferMaterialList.DataSource = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.IsSelected);
        }

        private void rpstRemove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int materialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewAddedOfferMaterialList.GetFocusedRowCellValue("Id"));
            OfferMaterialList selectedOfferMaterialList = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.Id == materialId).FirstOrDefault();
            selectedOfferMaterialList.IsSelected = false;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
            parameters.Add("MaterialListId", materialId);

            List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);

            foreach (var item in items)
            {
                item.IsMarkedForDeletion = true;
                SupplierMaterialListProvider.Instance.Save(item);
            }

            this.LoadMaterialGrid();
            this.LoadAddedMateriallistGrid();
        }
        private void rpstSupplierDetail_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            frm_TedarikciyeAktarilanMalzemeDetay md = new frm_TedarikciyeAktarilanMalzemeDetay(this);
            int selectedSupplierId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewSupplier.GetFocusedRowCellValue("Id"));
            md.SelectedSupplierId = selectedSupplierId;
            md.ShowDialog();
            this.Enabled = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void frm_TedarikcilereTeklifGonder_Load(object sender, EventArgs e)
        {
           
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (radioGroup1.SelectedIndex == 0)
            //{
            //    pnlMalzemeListesi.Enabled = true;
            //    pnlUst.Enabled = true;
            //    pnlFirma.Visible = false;
            //    pnlAktarilanlar.Visible = false;
            //    pnlMalzemeListesi.Dock = DockStyle.Fill;
            //    btnAktar.Visible = false;
            //}
            //if (radioGroup1.SelectedIndex == 1)
            //{
            //    btnAktar.Visible = true;
            //    btnAktar.Enabled = true;
            //    pnlMalzemeListesi.Enabled = true;
            //    pnlMalzemeListesi.Dock = DockStyle.Left;
            //    pnlUst.Enabled = true;
            //    pnlFirma.Visible = true;
            //    pnlAktarilanlar.Visible = true;

            //}

         }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //this.UpdateExcel();
            //this.ReadExcel();
        }

        private void UpdateExcel()
        {
            Microsoft.Office.Interop.Excel.Application oXL = null;
            Microsoft.Office.Interop.Excel._Workbook oWB = null;
            Microsoft.Office.Interop.Excel._Worksheet oSheet = null;
            string destFile = string.Empty;

            List<Supplier> suppliers = CurrentManager.Instance.CurrentOffer.Suppliers;
            foreach (Supplier supplier in suppliers)
            {
                try
                {
                    string fileName = "Malzeme_Fiyat_Listesi.xlsx";
                    string sourcePath = @"E:\Development\Clone\IhalematikPro\EmailFile";
                    string targetPath = @"E:\Development\Clone\IhalematikPro\EmailFile\SentFile";
                    string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                    destFile = System.IO.Path.Combine(targetPath, DateTime.Now.ToShortDateString().Replace("/", string.Empty) + Guid.NewGuid().ToString() + "-" + supplier.CompanyName + "-" + fileName);

                    if (!System.IO.Directory.Exists(targetPath))
                    {
                        System.IO.Directory.CreateDirectory(targetPath);
                    }
                    System.IO.File.Copy(sourceFile, destFile, true);

                    oXL = new Microsoft.Office.Interop.Excel.Application();
                    oWB = oXL.Workbooks.Open(destFile);
                    oSheet = String.IsNullOrEmpty("Sayfa1") ? (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet : (Microsoft.Office.Interop.Excel._Worksheet)oWB.Worksheets["Sayfa1"];

                    if (CurrentManager.Instance.CurrentOffer != null)
                    {
                        Dictionary<string, object> parameters = new Dictionary<string, object>();
                        parameters.Add("OfferId", CurrentManager.Instance.CurrentOffer.Id);
                        parameters.Add("SupplierId", supplier.Id);

                        List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems(parameters);
                        List<OfferMaterialList> offerMaterialLists = new List<OfferMaterialList>();
                        if (items.Count != 0)
                        {
                            offerMaterialLists.AddRange(items.Select(p => p.MaterialList));
                        }

                        if (offerMaterialLists.Count != 0)
                        {
                            int row = 2;
                            int indexNumber = 1;

                            foreach (OfferMaterialList materialList in offerMaterialLists)
                            {
                                oSheet.Cells[row, 1] = indexNumber;
                                oSheet.Cells[row, 2] = CurrentManager.Instance.CurrentOffer.Id;
                                oSheet.Cells[row, 3] = supplier.Id;//supplierId
                                oSheet.Cells[row, 4] = materialList.Id;
                                oSheet.Cells[row, 5] = materialList.PozOBF.Description;
                                oSheet.Cells[row, 6] = materialList.Quantity;
                                row++;
                                indexNumber++;
                            }
                        }
                    }

                    oWB.Save();

                    // MessageBox.Show("Done!");
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (oWB != null)
                        oWB.Close();
                    MailingManager.Instance.SendTesEmail(supplier.Email, destFile);
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
            pnlAktarilanlar.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlMalzemeListesi.Dock = DockStyle.Fill;
            
             
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnTedaikcileregonder_Click(object sender, EventArgs e)
        {
            pnlGonderilecekListe.Visible = false;
            pnlobfpozButtonpanel.Visible = false;

            pnlAktarilanlar.Visible = false;
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
        }

        private void btnTedarikciListesi_Click(object sender, EventArgs e)
        {
            pnlGonderilecekListe.Visible = true;
            pnlobfpozButtonpanel.Visible = false;
            pnlAktarilanlar.Visible = false;
            pnlMalzemeListesi.Visible = false;
            pnlAktarmaPaneli.Visible = false;
            pnlAktarilanlar.Visible = false;
            pnlFirma.Visible = true;
            pnlFirma.Dock = DockStyle.Fill;
            pnlFirma.BringToFront();
            colIsSelectedSupplier.Visible = false;


        }

        private void btnGonderilenMalzemeListesi_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            frm_GonderilecekMalzemeListesi gml = new frm_GonderilecekMalzemeListesi();
            gml.ShowDialog();
            this.Enabled = true;
            //pnlMalzemeListesi.Visible = false;
            //pnlFirma.Visible = false;
            //pnlAktarilanlar.Visible = false;
            //pnlAktarmaPaneli.Visible = false;
            //pnlMalzemeListesi.Visible = false;
            //pnlAktarilanlar.Visible = true;
            //pnlAktarilanlar.Dock = DockStyle.Fill;
            //pnlAktarilanlar.BringToFront();
        }
    }
}