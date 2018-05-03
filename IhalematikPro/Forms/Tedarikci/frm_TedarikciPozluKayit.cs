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
using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProUI.Model;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Base;

namespace IhalematikProUI.Forms.Tedarikci
{
    public partial class frm_TedarikciPozluKayit : IhalematikBaseForm
    {
        List<PozModel> pozModels = new List<PozModel>();
        IhalematikBaseForm _owner;

        public frm_TedarikciPozluKayit(IhalematikBaseForm Owner)
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
            this.LoadPozListGrid();
        }

        private void LoadPozListGrid()
        {
            string pozNumber = txtPozNumber.Text;
            string pozDescription = txtDescription.Text;

            pozModels = UIPozManager.Instance.GetPozs(pozNumber, pozDescription);
            List<OfferMaterialList> selectedMaterialLists = UICurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.IsPoz).ToList();

            if (selectedMaterialLists != null)
            {
                foreach (OfferMaterialList item in selectedMaterialLists)
                {
                    bool isExistingPozModel = false;
                    PozModel selectedOBFModel = null;
                    foreach (var pozModel in pozModels)
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
                        pozModels.Remove(selectedOBFModel);
                    }
                }
            }


            grdPozList.DataSource = pozModels;

        }

        private void frm_TedarikciPozluKayit_Shown(object sender, EventArgs e)
        {
            if (UICurrentManager.Instance.CurrentOffer != null && UICurrentManager.Instance.CurrentOffer.MaterialList != null)
            {
                List<OfferMaterialList> items = UICurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.IsPoz).ToList();
                List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(items).ToList();
                grdAddedPoz.DataSource = models;
                txtPozNumber.Focus();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Offer currentOffer = UICurrentManager.Instance.CurrentOffer;

            int[] selectedRows = gridView1.GetSelectedRows();

            List<PozModel> dataSource = grdPozList.DataSource as List<PozModel>;
            if (dataSource == null)
            {
                return;
            }
            PozModel[] selectedRowsItems = dataSource.ToArray();

            foreach (int item in selectedRows)
            {
                PozModel pozModel = selectedRowsItems[item];
                OfferMaterialList materialList = new OfferMaterialList();
                materialList.IsPoz = true;
                materialList.PozOBFId = pozModel.Id.Value;
                materialList.Offer = currentOffer;
                List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && p.IsPoz).ToList();

                if (items.Count == 0)
                {

                    currentOffer.MaterialList.Add(materialList);
                }
            }

            List<OfferMaterialList> offerMaterialLists = currentOffer.MaterialList.Where(p => p.IsPoz).ToList();
            List<OfferMaterialListModel> models = new List<OfferMaterialListModel>();
            foreach (OfferMaterialList item in offerMaterialLists)
            {
                OfferMaterialListModel model = new OfferMaterialListModel(item);
                models.Add(model);
            }

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = models;
            this.LoadPozListGrid();
        }

        private void btnListedenCikar_Click(object sender, EventArgs e)
        {
            Offer currentOffer = UICurrentManager.Instance.CurrentOffer;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<OfferMaterialListModel> models = (List<OfferMaterialListModel>)gridView2.DataSource;
            OfferMaterialListModel[] selectedRowsItems = models.ToArray();

            foreach (int item in selectedRows)
            {

                OfferMaterialListModel pozModel = selectedRowsItems[item];
                OfferMaterialList selectedItem = currentOffer.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).Single();
                currentOffer.MaterialList.Remove(selectedItem);
                if (selectedItem.Id > 0)
                {
                    selectedItem.IsMarkedForDeletion = true;
                    OfferMaterialListProvider.Instance.Save(selectedItem);
                }
            }

            List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => p.IsPoz && !p.IsMarkedForDeletion).ToList();
            List<OfferMaterialListModel> dataSource = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(items).ToList();

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = dataSource;
            this.LoadPozListGrid();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Offer currentOffer = UICurrentManager.Instance.CurrentOffer;
            if (currentOffer.MaterialList != null)
            {
                List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => p.IsPoz).ToList();
                foreach (OfferMaterialList item in items)
                {
                    OfferMaterialListProvider.Instance.Save(item);
                }
            }

            if (this._owner is frm_TedarikcilereTeklifGonder)
            {
                ((frm_TedarikcilereTeklifGonder)this._owner).LoadMaterialGrid();
            }

            //if (this._owner is frm_TedarikciyeAktarilanMalzemeDetay)
            //{
            //   // ((frm_TedarikcilereGonderilmeyecekListeOlustur)this._owner).LoadMaterialGrid();
            //}

            this.Close();
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