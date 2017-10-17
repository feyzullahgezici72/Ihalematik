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

        public frm_ObfKayit()
        {
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
            if (GlobalVeriablesManager.MaterialList == null)
            {
                GlobalVeriablesManager.MaterialList = new List<MaterialList>();
            }
            int[] selectedRows = gridView1.GetSelectedRows();

            OBFModel[] selectedRowsItems = oBFModels.ToArray();

            foreach (int item in selectedRows)
            {
                OBFModel pozModel = selectedRowsItems[item];
                MaterialList materialList = new MaterialList();
                materialList.IsPoz = false;
                materialList.PozOBFId = pozModel.Id.Value;

                List<MaterialList> items = GlobalVeriablesManager.MaterialList.Where(p => p.PozOBFId == materialList.PozOBFId && !p.IsPoz).ToList();

                if (items.Count == 0)
                {
                    GlobalVeriablesManager.MaterialList.Add(materialList);
                }
            }

            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(GlobalVeriablesManager.MaterialList.Where(p => !p.IsPoz).ToList());

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = models;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
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

            List<MaterialListModel> dataSource = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(GlobalVeriablesManager.MaterialList.Where(p => !p.IsPoz).ToList());

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = dataSource;
        }
    }
}