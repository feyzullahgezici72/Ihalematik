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

namespace IhalematikPro.Forms
{
    public partial class frm_PozluKayit : DevExpress.XtraEditors.XtraForm
    {
        List<PozModel> pozModels = new List<PozModel>();

        frm_Teklif_Adim1 _owner;
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
            if (GlobalVeriablesManager.MaterialList == null)
            {
                GlobalVeriablesManager.MaterialList = new List<MaterialList>();
            }
            int[] selectedRows = gridView1.GetSelectedRows();

            PozModel[] selectedRowsItems = pozModels.ToArray();

            foreach (int item in selectedRows)
            {
                PozModel pozModel = selectedRowsItems[item];
                MaterialList materialList = new MaterialList();
                materialList.IsPoz = true;
                materialList.PozOBFId = pozModel.Id.Value;
                List<MaterialList> items = GlobalVeriablesManager.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && p.IsPoz).ToList();

                if (items.Count == 0)
                {
                    GlobalVeriablesManager.MaterialList.Add(materialList);
                }
            }

            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(GlobalVeriablesManager.MaterialList.Where(p => p.IsPoz).ToList());

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = models;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            _owner.RefreshDataGrid();
            //this.RefreshDgv("", "", "");
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView2.GetSelectedRows();
            List<MaterialListModel> models = (List<MaterialListModel>)gridView2.DataSource;

            MaterialListModel[] selectedRowsItems = models.ToArray();

            GlobalVeriablesManager.MaterialList.ForEach(p => p.Id = p.PozOBFId);

            foreach (int item in selectedRows)
            {
                MaterialListModel pozModel = selectedRowsItems[item];

                MaterialList selectedItem = GlobalVeriablesManager.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).Single();
                
                if (selectedItem != null)
                {
                    int index = GlobalVeriablesManager.MaterialList.IndexOf(selectedItem);

                    GlobalVeriablesManager.MaterialList.RemoveAt(index);
                }
            }

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(GlobalVeriablesManager.MaterialList.Where(p => p.IsPoz).ToList());

            grdAddedPoz.DataSource = null;
            grdAddedPoz.DataSource = dataSource;
        }

        private void txtPozNumber_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}