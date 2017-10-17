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
using IhalematikProBL.Provider;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim1 : DevExpress.XtraEditors.XtraForm
    {
        public frm_Teklif_Adim1()
        {
            InitializeComponent();
        }

        Forms.frm_ObfKayit okf = new frm_ObfKayit();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            okf.ShowDialog();
        }
        Forms.frm_PozluKayit pkf = new frm_PozluKayit();
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pkf.ShowDialog();
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Teklif_Adim1_Load(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = null;
            bindingSource1.DataSource = GlobalVeriablesManager.MaterialList; //typeof(List<MaterialList>);
            grdMaterialList.DataSource = bindingSource1;          
            lblTenderDescription.Text = GlobalVeriablesManager.CurrentTender.Description;
            lblTenderNumber.Text = GlobalVeriablesManager.CurrentTender.DisplayNumber;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Frm_Teklif_Adim1_KeyDown);
        }

        private void Frm_Teklif_Adim1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode.ToString() == "F1")
            {
                pkf.ShowDialog();
            }
            if (e.KeyCode.ToString() == "F2")
            {
                okf.ShowDialog();
            }
        }

      
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int[] selectedRows = grdMaterialList2.GetSelectedRows();

            MaterialList[] items = GlobalVeriablesManager.MaterialList.ToArray();

            foreach (int rowIndex in selectedRows)
            {
                MaterialList item = items[rowIndex];
                item.IsWorkship = true;
            }

            foreach (MaterialList item in GlobalVeriablesManager.MaterialList)
            {
                item.TenderId = GlobalVeriablesManager.CurrentTender.Id;
                MaterialListProvider.Instance.Save(item);
            }

            MessageBox.Show("Malzemler Kaydedildi...");

            this.Close();

            frm_Anaform frm = new frm_Anaform();
            frm.btnAdimx3.PerformClick();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = GlobalVeriablesManager.MaterialList;
            grdMaterialList.RefreshDataSource();
        }

        private void grdMaterialList2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double baseAmount = GlobalVeriablesManager.MaterialList.Sum(p => p.TotalAmount);
            double baseKDVAmount = GlobalVeriablesManager.MaterialList.Sum(p => p.KDVAmount);

            txtBaseAmount.Text = string.Format("{0:C2}", baseAmount);
            txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
            txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + baseAmount), 2));
        }

        private void grdMaterialList2_ColumnUnboundExpressionChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}