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

namespace IhalematikPro.Forms
{
    public partial class frm_ObfKayit : DevExpress.XtraEditors.XtraForm
    {
        List<OBFModel> oBFModels = new List<OBFModel>();

        frm_Teklif_Adim1 _owner;
        public frm_ObfKayit(frm_Teklif_Adim1 Owner)
        {
            _owner = Owner;
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string obfNo = txtNumber.Text;

            oBFModels = UIOBFManager.Instance.GetOBFs(obfNo);

            grdOBFList.DataSource = oBFModels;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (CurrentManager.MaterialList == null)
            {
                CurrentManager.MaterialList = new List<MaterialList>();
            }
            int[] selectedRows = gridView1.GetSelectedRows();

            OBFModel[] selectedRowsItems = oBFModels.ToArray();

            foreach (int item in selectedRows)
            {
                OBFModel pozModel = selectedRowsItems[item];
                MaterialList materialList = new MaterialList();
                materialList.IsPoz = false;
                materialList.PozOBFId = pozModel.Id.Value;

                List<MaterialList> items = CurrentManager.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && !p.IsPoz).ToList();

                if (items.Count == 0)
                {
                    CurrentManager.MaterialList.Add(materialList);
                }
            }

            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(CurrentManager.MaterialList.Where(p => !p.IsPoz).ToList());

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = models;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this._owner.RefreshDataGrid();
            this.Close();  
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView2.GetSelectedRows();
            List<MaterialListModel> models = (List<MaterialListModel>)gridView2.DataSource;

            MaterialListModel[] selectedRowsItems = models.ToArray();

            CurrentManager.MaterialList.ForEach(p => p.Id = p.PozOBFId);

            foreach (int item in selectedRows)
            {
                MaterialListModel pozModel = selectedRowsItems[item];

                MaterialList selectedItem = CurrentManager.MaterialList.Where(p => p.PozOBFId == pozModel.PozOBFId).Single();

                if (selectedItem != null)
                {
                    int index = CurrentManager.MaterialList.IndexOf(selectedItem);

                    CurrentManager.MaterialList.RemoveAt(index);
                }
            }

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(CurrentManager.MaterialList.Where(p => !p.IsPoz).ToList());

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = dataSource;
        }
    }
}