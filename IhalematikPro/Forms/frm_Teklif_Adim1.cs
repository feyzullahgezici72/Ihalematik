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

        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Forms.frm_ObfKayit okf = new frm_ObfKayit(this);
            okf.ShowDialog();
        }
       
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_PozluKayit pkf = new frm_PozluKayit(this);
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
            bindingSource1.DataSource = CurrentManager.CurrentTender.MaterialList; //typeof(List<MaterialList>);
            grdMaterialList.DataSource = bindingSource1;
            lblTenderDescription.Text = CurrentManager.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.CurrentTender.DisplayNumber;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Frm_Teklif_Adim1_KeyDown);
        }

        private void Frm_Teklif_Adim1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                frm_PozluKayit pkf = new frm_PozluKayit(this);
                pkf.ShowDialog();
            }
            if (e.KeyCode.ToString() == "F2")
            {
                Forms.frm_ObfKayit okf = new frm_ObfKayit(this);
                okf.ShowDialog();
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int[] selectedRows = grdMaterialList2.GetSelectedRows();

            MaterialList[] items = CurrentManager.CurrentTender.MaterialList.ToArray();

            foreach (int rowIndex in selectedRows)
            {
                MaterialList item = items[rowIndex];
                item.IsWorkship = true;
            }

            foreach (MaterialList item in CurrentManager.CurrentTender.MaterialList)
            {
                item.TenderId = CurrentManager.CurrentTender.Id;
                MaterialListProvider.Instance.Save(item);
            }
            this.Enabled = false;
            frm_ihaleOlustuMesaj frm = new frm_ihaleOlustuMesaj();
            frm.lblMesaj.Text = "Malzemeler Kaydedildi...";
            frm.ShowDialog();
            //MessageBox.Show("Malzemler Kaydedildi...");

            this.Close();

            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
             
            af.btnAdimx3.Enabled = true;
            af.btnAdimx4.Enabled = true;
            af.btnAdimx5.Enabled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = CurrentManager.CurrentTender.MaterialList;
            grdMaterialList.RefreshDataSource();
        }

        private void grdMaterialList2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double baseAmount = CurrentManager.CurrentTender.MaterialList.Sum(p => p.TotalAmount);
            double baseKDVAmount = CurrentManager.CurrentTender.MaterialList.Sum(p => p.KDVAmount);

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

        public void RefreshDataGrid()
        {
            grdMaterialList.DataSource = CurrentManager.CurrentTender.MaterialList;
            grdMaterialList.RefreshDataSource();
        }
    }
}