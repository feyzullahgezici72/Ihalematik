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
            string pozNumber = txtPozNumber.Text;
            string pozDescription = txtDescription.Text;

            pozModels = UIPozManager.Instance.GetPozs(pozNumber, pozDescription);
            grdPozList.DataSource = pozModels;
        }

        private void frm_TedarikciPozluKayit_Shown(object sender, EventArgs e)
        {
            List<OfferMaterialList> items = CurrentManager.Instance.CurrentOffer.MaterialList.Where(p => p.IsPoz).ToList();
            List<OfferMaterialListModel> models = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(items).ToList();
            grdAddedPoz.DataSource = models;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Offer currentOffer = CurrentManager.Instance.CurrentOffer;

            int[] selectedRows = gridView1.GetSelectedRows();

            PozModel[] selectedRowsItems = pozModels.ToArray();

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

            List<OfferMaterialList> offerMaterialLists = currentOffer.MaterialList;
            List<OfferMaterialListModel> models = new List<OfferMaterialListModel>();
            foreach (OfferMaterialList item in offerMaterialLists)
            {
                OfferMaterialListModel model = new OfferMaterialListModel(item);
                models.Add(model);
            }

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = models;
        }

        private void btnListedenCikar_Click(object sender, EventArgs e)
        {
            Offer currentOffer = CurrentManager.Instance.CurrentOffer;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<OfferMaterialListModel> models = (List<OfferMaterialListModel>)gridView2.DataSource;
            OfferMaterialListModel[] selectedRowsItems = models.ToArray();

            foreach (int item in selectedRows)
            {
                OfferMaterialListModel pozModel = selectedRowsItems[item];
                var selectedItem = currentOffer.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).SingleOrDefault();

                if (selectedItem != null)
                {
                    selectedItem.IsMarkedForDeletion = true;
                    //int index = currentOffer.MaterialList.FindIndex(p => p.PozOBFId == selectedItem.PozOBFId);
                    //currentOffer.MaterialList.RemoveAt(index);
                }
            }

            List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => p.IsPoz && !p.IsMarkedForDeletion).ToList();
            List <OfferMaterialListModel> dataSource = IhalematikModelBase.GetModels<OfferMaterialListModel, OfferMaterialList>(items).ToList();

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = dataSource;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Offer currentOffer = CurrentManager.Instance.CurrentOffer;
            if (currentOffer.MaterialList != null)
            {
                List<OfferMaterialList> items = currentOffer.MaterialList.Where(p => p.IsPoz).ToList();
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