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
using IhalematikProUI.Model;
using IhalematikPro.Model;
using IhalematikProUI.Forms;
using System.Threading;
using IhalematikProUI.Forms.Base;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim1 : IhalematikBaseForm
    {
        private object a4;

        public int SelectedGroupId { get; set; }

        public frm_Teklif_Adim1()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Forms.frm_ObfKayit okf = new frm_ObfKayit(this);
            okf.SelectedGroupId = this.SelectedGroupId;
            okf.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_PozluKayit pkf = new frm_PozluKayit(this);
            pkf.SelectedGroupId = this.SelectedGroupId;
            pkf.ShowDialog();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Teklif_Adim1_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Frm_Teklif_Adim1_KeyDown);
            this.LoadTenderGroupGrid();
        }
        public void LoadTenderGroupGrid()
        {
            List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);
            models[0].IsSelected = true;
            grdTenderGroup.DataSource = models;

            this.SelectedGroupId = models[0].Id.Value;
            this.LoadTenderMaterialList();
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
            //this.SaveMaterialListIsWorkship();

            this.OpenForm2();
        }

        private void SaveMaterialListIsWorkship()
        {
            int[] selectedRows = grdMaterialList2.GetSelectedRows();

            MaterialList[] items = CurrentManager.Instance.CurrentTender.MaterialList.ToArray();

            foreach (int rowIndex in selectedRows)
            {
                MaterialList item = items[rowIndex];
                item.IsWorkship = true;
            }

            foreach (MaterialList item in CurrentManager.Instance.CurrentTender.MaterialList)
            {
                item.TenderId = CurrentManager.Instance.CurrentTender.Id;
                MaterialListProvider.Instance.Save(item);
            }
        }

        private void OpenForm2()
        {
            this.Enabled = false;
            frm_MesajFormu frm = new frm_MesajFormu();
            frm.lblMesaj.Text = "Malzemeler Kaydedildi...";
            frm.ShowDialog();
            //MessageBox.Show("Malzemler Kaydedildi...");
            this.Close();
            frm_Teklif_Adim2 a4 = (frm_Teklif_Adim2)Application.OpenForms["frm_Teklif_Adim2"];
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            if (a4 == null)
            {
                a4 = new frm_Teklif_Adim2();
                a4.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                a4.FormClosed += new FormClosedEventHandler(a4_FormClosed);
                af.MainPanel.Visible = false;
                a4.Show();

            }
            else
            {
                a4.Activate();
            }
        }

        private void a4_FormClosed(object sender, FormClosedEventArgs e)
        {
            a4 = null;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            grdMaterialList.DataSource = CurrentManager.Instance.CurrentTender.MaterialList;
            grdMaterialList.RefreshDataSource();
        }

        private void grdMaterialList2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            double baseAmount = CurrentManager.Instance.CurrentTender.MaterialList.Sum(p => p.TotalAmount);
            double baseKDVAmount = CurrentManager.Instance.CurrentTender.MaterialList.Sum(p => p.KDVAmount);

            txtBaseAmount.Text = string.Format("{0:C2}", baseAmount);
            txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
            txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + baseAmount), 2));
        }

        public void RefreshDataGrid()
        {
            if (this.SelectedGroupId != 0)
            {
                grdMaterialList.DataSource = CurrentManager.Instance.CurrentTender.MaterialList.Where(p=> p.TenderGroupId == this.SelectedGroupId);
                grdMaterialList.RefreshDataSource(); 
            }
        }

        private void gridViewTenderGroup_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            for (int i = 0; i < gridViewTenderGroup.RowCount; i++)
            {
                gridViewTenderGroup.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewTenderGroup.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            this.LoadTenderMaterialList();
        }

        public void LoadTenderMaterialList()
        {
            if (this.SelectedGroupId != 0 && CurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList(); 
                grdMaterialList.DataSource = items;
            }
        }

        private void rpstSelected_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewTenderGroup.RowCount; i++)
            {
                gridViewTenderGroup.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewTenderGroup.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            LoadTenderMaterialList();
        }
    }
}