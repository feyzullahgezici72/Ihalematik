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
using IhalematikPro.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Base;
using IhalematikProBL.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_PozluKayit : IhalematikBaseForm
    {
        List<PozModel> pozModels = new List<PozModel>();

        IhalematikBaseForm _owner;

        public int SelectedGroupId { get; set; }

        public frm_PozluKayit(IhalematikBaseForm owner)
        {
            _owner = owner;
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

        private void LoadMaterialListGrid()
        {
            string pozNumber = txtPozNumber.Text;
            string pozDescription = txtDescription.Text.Trim();
            pozModels = new List<PozModel>();
            Offer offer = CurrentManager.Instance.CurrentTender.Offer;
            List<MaterialList> selectedMaterialLists = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsPoz).ToList();

            if (offer == null)
            {
                pozModels = UIPozManager.Instance.GetPozs(pozNumber, pozDescription);
            }

            else
            {
                List<OfferMaterialList> items = offer.MaterialList.Where(p => p.IsPoz).ToList();
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
                            if (!string.IsNullOrEmpty(pozNumber))
                            {
                                if (item.PozOBF.Number.Contains(pozNumber))
                                {
                                    PozModel model = new PozModel();
                                    model.Description = item.PozOBF.Description;
                                    model.Number = item.PozOBF.Number;
                                    model.Unit = item.PozOBF.Unit;
                                    model.UnitPrice = item.PozOBF.UnitPrice;
                                    double offerPrice = OfferManager.Instance.GetOfferMaterialListPrice(item.Id).Price;
                                    model.OfferPrice = offerPrice;
                                    model.Id = item.PozOBFId;
                                    pozModels.Add(model);
                                }
                            }
                            else
                            {
                                PozModel model = new PozModel();
                                model.Description = item.PozOBF.Description;
                                model.Number = item.PozOBF.Number;
                                model.Unit = item.PozOBF.Unit;
                                model.UnitPrice = item.PozOBF.UnitPrice;
                                double offerPrice = OfferManager.Instance.GetOfferMaterialListPrice(item.Id).Price;
                                model.OfferPrice = offerPrice;
                                model.Id = item.PozOBFId;
                                pozModels.Add(model);
                            }
                        }
                    }
                }

            }
            grdPozList.DataSource = null;
            grdPozList.DataSource = pozModels;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;

            int[] selectedRows = gridView1.GetSelectedRows();

            PozModel[] selectedRowsItems = pozModels.ToArray();

            foreach (int item in selectedRows)
            {
                PozModel pozModel = selectedRowsItems[item];
                MaterialList materialList = new MaterialList();
                materialList.IsPoz = true;
                materialList.PozOBFId = pozModel.Id.Value;
                materialList.Tender = currentTender;
                materialList.TenderGroupId = this.SelectedGroupId;
                materialList.OfferPrice = pozModel.OfferPrice;
                List<MaterialList> items = currentTender.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && p.IsPoz).ToList();

                if (items.Count == 0)
                {
                    currentTender.MaterialList.Add(materialList);
                }
            }

            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(currentTender.MaterialList.Where(p => p.IsPoz && p.TenderGroupId == this.SelectedGroupId).ToList());

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = models;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            if (currentTender.MaterialList != null)
            {
                List<MaterialList> items = currentTender.MaterialList.Where(p => p.IsPoz && p.TenderGroupId == this.SelectedGroupId).ToList();
                foreach (MaterialList item in items)
                {
                    if (item.IsMarkedForDeletion)
                    {
                        currentTender.MaterialList.Remove(item);
                    }
                    item.TenderGroupId = this.SelectedGroupId;
                    MaterialListProvider.Instance.Save(item);
                }
            }
            if (this._owner is frm_Teklif_Adim1)
            {
                ((frm_Teklif_Adim1)_owner).LoadTenderMaterialList();
            }

            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<MaterialListModel> models = (List<MaterialListModel>)gridView2.DataSource;

            MaterialListModel[] selectedRowsItems = models.ToArray();

            foreach (int item in selectedRows)
            {
                MaterialListModel pozModel = selectedRowsItems[item];

                MaterialList selectedItem = currentTender.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).Single();

                if (selectedItem != null)
                {
                    int index = currentTender.MaterialList.FindIndex(p => p.PozOBFId == selectedItem.PozOBFId);
                    currentTender.MaterialList.RemoveAt(index);
                }
            }

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(currentTender.MaterialList.Where(p => p.IsPoz && p.TenderGroupId == this.SelectedGroupId).ToList());

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = dataSource;
            this.LoadMaterialListGrid();
        }

        private void frm_PozluKayit_Load(object sender, EventArgs e)
        {

        }

        private void frm_PozluKayit_Shown(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentTender.Offer == null)
            {
                colOfferPrice.Visible = false;
                colAddedPozOfferPrice.Visible = false;
                colPrice.Visible = true;
                colAddedPozPrice.Visible = true;
            }
            else
            {
                colOfferPrice.Visible = true;
                colAddedPozOfferPrice.Visible = true;
                colPrice.Visible = false;
                colAddedPozPrice.Visible = false;
            }

            this.LoadMaterialListGrid();

            this.LoadAddedPozGrid();
        }

        private void LoadAddedPozGrid()
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId && p.IsPoz).ToList();

            Offer offer = CurrentManager.Instance.CurrentTender.Offer;
            foreach (var item in items)
            {
                OfferMaterialList offerMaterialList = offer.MaterialList.Where(p => p.PozOBFId == item.PozOBFId && p.IsPoz).FirstOrDefault();
                if (offerMaterialList != null)
                {
                    item.OfferPrice = OfferManager.Instance.GetOfferMaterialListPrice(offerMaterialList.Id).Price;
                }
            }

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items).ToList();
            grdAddedPoz.DataSource = dataSource;
        }

        private void txtPozNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnBul.PerformClick();
            }
        }
    }
}