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

namespace IhalematikPro.Forms
{
    public partial class frm_PozluKayit : DevExpress.XtraEditors.XtraForm
    {
        List<PozModel> pozModels = new List<PozModel>();

        frm_Teklif_Adim1 _owner;

        public int SelectedGroupId { get; set; }

        public frm_PozluKayit(frm_Teklif_Adim1 owner)
        {
            _owner = owner;
            InitializeComponent();
            //grdPozList..MultiSelect = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string pozNo = txtPozNumber.Text;

            pozModels = UIPozManager.Instance.GetPozs(pozNo);

            grdPozList.DataSource = pozModels;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

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
            _owner.RefreshDataGrid();
            //this.RefreshDgv("", "", "");
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Tender currentTender = CurrentManager.Instance.CurrentTender;
            int[] selectedRows = gridView2.GetSelectedRows();
            List<MaterialListModel> models = (List<MaterialListModel>)gridView2.DataSource;

            MaterialListModel[] selectedRowsItems = models.ToArray();

            //currentTender.MaterialList.ForEach(p => p.Poz = p.PozOBFId);

            foreach (int item in selectedRows)
            {
                MaterialListModel pozModel = selectedRowsItems[item];

                MaterialList selectedItem = currentTender.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).Single();

                if (selectedItem != null)
                {
                    selectedItem.IsMarkedForDeletion = true;
                    int index = currentTender.MaterialList.IndexOf(selectedItem);

                    //currentTender.MaterialList.RemoveAt(index);
                }
            }

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(currentTender.MaterialList.Where(p => p.IsPoz && p.TenderGroupId == this.SelectedGroupId && !p.IsMarkedForDeletion).ToList());

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = dataSource;
        }

        private void txtPozNumber_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_PozluKayit_Load(object sender, EventArgs e)
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items).ToList();
            grdAddedPoz.DataSource = dataSource;
        }
    }
}