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
                    frm_Teklif_Adim1 frm = new frm_Teklif_Adim1();
                    frm.grdMaterialList.DataSource = null;
                    frm.grdMaterialList.DataSource = new BindingSource(GlobalVeriablesManager.MaterialList, "");
                }

                //frm.grdMaterialList.DataSource = GlobalVeriablesManager.MaterialList;
            }

            grdAddedOBF.DataSource = null;
            grdAddedOBF.DataSource = models;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}