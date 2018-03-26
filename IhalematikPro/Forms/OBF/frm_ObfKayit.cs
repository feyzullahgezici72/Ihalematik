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
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikPro.Model;
using IhalematikProBL.Provider;
using IhalematikProBL.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_ObfKayit : DevExpress.XtraEditors.XtraForm
    {
        List<OBFModel> oBFModels = new List<OBFModel>();

        frm_Teklif_Adim1 _owner;
        public int SelectedGroupId { get; set; }

        private TenderGroup tenderGroup { get; set; }
        public TenderGroup SelectedGroup
        {
            get
            {
                if (this.tenderGroup == null)
                {
                    this.tenderGroup = TenderGroupProvider.Instance.GetItem(this.SelectedGroupId);
                }
                return this.tenderGroup;
            }
        }
        public frm_ObfKayit(frm_Teklif_Adim1 Owner)
        {
            _owner = Owner;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            this.LoadMaterialListGrid();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;

            int[] selectedRows = gridView1.GetSelectedRows();

            OBFModel[] dataSource = grdOBFList.DataSource as OBFModel[];
            if (dataSource == null)
            {
                return;
            }

            OBFModel[] selectedRowsItems = dataSource.ToArray();

            foreach (int item in selectedRows)
            {
                OBFModel obfModel = selectedRowsItems[item];
                MaterialList materialList = new MaterialList();
                materialList.IsPoz = false;
                materialList.PozOBFId = obfModel.Id.Value;
                materialList.Tender = currentTender;
                materialList.TenderGroupId = this.SelectedGroupId;
                materialList.OfferPrice = obfModel.OfferPrice;
                List<MaterialList> items = currentTender.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && !p.IsPoz).ToList();

                if (items.Count == 0)
                {
                    currentTender.MaterialList.Add(materialList);
                    int index = oBFModels.FindIndex(p => p.Id == obfModel.Id);
                    oBFModels.RemoveAt(index);
                }
            }

            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(currentTender.MaterialList.Where(p => !p.IsPoz && p.TenderGroupId == this.SelectedGroupId).ToList());

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = models;
            grdOBFList.DataSource = null;
            grdOBFList.DataSource = oBFModels;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            if (currentTender.MaterialList != null)
            {
                List<MaterialList> items = currentTender.MaterialList.Where(p => !p.IsPoz && p.TenderGroupId == this.SelectedGroupId).ToList();
                foreach (MaterialList item in items)
                {
                    item.KDVPercentage = 18;
                    item.TenderGroupId = this.SelectedGroupId;
                    MaterialListProvider.Instance.Save(item);
                }
            }

            this._owner.LoadTenderMaterialList();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<MaterialListModel> models = (List<MaterialListModel>)gridView2.DataSource;

            MaterialListModel[] selectedRowsItems = models.ToArray();

            // currentTender.MaterialList.ForEach(p => p.Id = p.PozOBFId);

            foreach (int item in selectedRows)
            {
                MaterialListModel pozModel = selectedRowsItems[item];
                MaterialList selectedItem = currentTender.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).Single();
                currentTender.MaterialList.Remove(selectedItem);
                if (selectedItem.Id > 0)
                {
                    selectedItem.IsMarkedForDeletion = true;
                    MaterialListProvider.Instance.Save(selectedItem);
                }
            }

            List<MaterialList> items = currentTender.MaterialList.Where(p => !p.IsPoz && p.TenderGroupId == this.SelectedGroupId).ToList();
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items).ToList();

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = dataSource;
            this.LoadMaterialListGrid();
        }

        private void frm_ObfKayit_Shown(object sender, EventArgs e)
        {
            lblGrupName.Text = this.SelectedGroup.Description;
            txtNumber.Focus();
            if (CurrentManager.Instance.CurrentTender.Offer == null)
            {
                colOfferPrice.Visible = false;
                colAddedOBFOfferPrice.Visible = false;
                colPrice.Visible = true;
                colAddedOBFPrice.Visible = true;
            }
            else
            {
                colOfferPrice.Visible = true;
                colAddedOBFOfferPrice.Visible = true;
                colPrice.Visible = false;
                colAddedOBFPrice.Visible = false;
                this.LoadMaterialListGrid();
            }
            this.LoadAddedOBFGrid();
        }

        private void LoadAddedOBFGrid()
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId && !p.IsPoz).ToList();

            Offer offer = CurrentManager.Instance.CurrentTender.Offer;
            if (offer != null)
            {
                foreach (var item in items)
                {
                    OfferMaterialList offerMaterialList = offer.MaterialList.Where(p => p.PozOBFId == item.PozOBFId && !p.IsPoz).FirstOrDefault();
                    if (offerMaterialList != null)
                    {
                        item.OfferPrice = OfferManager.Instance.GetOfferMaterialListPrice(offerMaterialList.Id).Price;
                    }
                }
            }

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items).ToList();
            grdAddedOBF.DataSource = dataSource;
        }

        private void LoadMaterialListGrid()
        {
            string obfNumber = txtNumber.Text;
            string obfDescription = txtDescription.Text;

            oBFModels = new List<OBFModel>();
            Offer offer = CurrentManager.Instance.CurrentTender.Offer;
            List<MaterialList> selectedMaterialLists = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => !p.IsPoz).ToList();

            if (offer == null)
            {
                oBFModels = UIOBFManager.Instance.GetOBFs(obfNumber, obfDescription).Where(p => p.IsActive).ToList();
                if (selectedMaterialLists != null)
                {
                    foreach (MaterialList item in selectedMaterialLists)
                    {
                        bool isExistingPozModel = false;
                        OBFModel selectedOBFModel = null;
                        foreach (var pozModel in oBFModels)
                        {
                            if (pozModel.Id == item.PozOBFId)
                            {
                                isExistingPozModel = true;
                                selectedOBFModel = pozModel;
                                break;
                            }
                        }

                        if (isExistingPozModel)
                        {
                            oBFModels.Remove(selectedOBFModel);
                        }
                    }
                }
            }

            else
            {
                List<OfferMaterialList> items = offer.MaterialList.Where(p => !p.IsPoz).ToList();
                if (items != null && items.Count != 0)
                {
                    foreach (var item in items)
                    {
                        bool isExist = false;

                        foreach (var selectedMaterialList in selectedMaterialLists)
                        {
                            if (selectedMaterialList.PozOBFId == item.PozOBFId)
                            {
                                isExist = true;
                                break;
                            }
                        }

                        if (!isExist)
                        {
                            OBFModel model = new OBFModel();
                            model.Description = item.PozOBF.Description;
                            model.Number = item.PozOBF.Number;
                            model.Unit = item.PozOBF.Unit;
                            model.UnitPrice = item.PozOBF.UnitPrice;
                            model.Id = item.PozOBFId;
                            double offerPrice = 0;
                            if (item.IsSelected)
                            {
                                // Malzeme tedarikciye gonderilmisse fiyatini offerMatetialdan ceksin.
                                offerPrice = OfferManager.Instance.GetOfferMaterialListPrice(item.Id).Price;
                                model.OfferPrice = offerPrice;
                            }
                            else
                            {
                                offerPrice = item.PozOBF.UnitPrice; // Malzeme tedarikciye gonderilmemisse fiyatini obf den ceksin.
                                model.OfferPrice = offerPrice;
                            }
                            
                            if (!string.IsNullOrEmpty(obfNumber))
                            {
                                if (item.PozOBF.Number.Contains(obfNumber))
                                {
                                    oBFModels.Add(model);
                                }
                            }
                            else if (!string.IsNullOrEmpty(obfDescription))
                            {
                                if (item.PozOBF.Description.Contains(obfDescription))
                                {
                                    oBFModels.Add(model);
                                }
                            }
                            else
                            {
                                oBFModels.Add(model);
                            }
                        }
                    }
                }

            }
            grdOBFList.DataSource = null;
            grdOBFList.DataSource = oBFModels;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBul.PerformClick();
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnBul.PerformClick();
            }
        }

        private void frm_ObfKayit_Load(object sender, EventArgs e)
        {

        }
    }
}