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
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikPro.Manager;
using IhalematikPro.Model;
using IhalematikProUI.Model;
using IhalematikProUI.Forms;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim2 : DevExpress.XtraEditors.XtraForm
    {
        private object a3;
        public int SelectedGroupId { get; set; }

        public frm_Teklif_Adim2()
        {
            InitializeComponent();
            bindingSourceMaterialListNonWorkship.DataSource = typeof(List<MaterialListModel>);
            grdMaterialListNonWorkship.DataSource = bindingSourceMaterialListNonWorkship;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_Teklif_Adim2_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            this.LoadTenderGroupGrid();
            this.CalculateTotalMarkup();
        }

        private void CalculateTotalMarkup()
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
            if (items != null)
            {
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                double baseAmount = 0;
                this.CalculateInnerValue(ref baseAmount);
                lblTotalMarkup.Text = (models.Sum(p => p.TotalMarkup)).ToString("C2");
            }
        }

        public void LoadTenderGroupGrid()
        {
            List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);
            grdTenderGroup.DataSource = models;
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMarkup.Text.Replace("%", ""));
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
            foreach (var item in items)
            {
                item.Markup = markup;
                MaterialListProvider.Instance.Save(item);
            }


            this.CalculateTotalMarkup();
            this.LoadTenderMaterialList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colMarkup)
            {
                double baseAmount = 0;
                this.CalculateInnerValue(ref baseAmount);
            }
        }

        private void CalculateInnerValue(ref double BaseAmount)
        {
            List<MaterialListModel> items = grdMaterialListNonWorkship.DataSource as List<MaterialListModel>;//CurrentManager.CurrentTender.MaterialList;//.Instance.GetMaterialListNonWorkship();
            if (items != null)
            {
                BaseAmount = items.Sum(p => p.Markup * p.Quantity);
                double baseKDVAmount = items.Sum(p => p.KDVAmount);

                txtBaseAmount.Text = string.Format("{0:C2}", BaseAmount);
                txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
                txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + BaseAmount), 2));

                lblTotalMarkup.Text = (items.Sum(p => p.TotalMarkup)).ToString("C2");
            }
        }
        frm_TeklifAdimSon a4 = (frm_TeklifAdimSon)Application.OpenForms["frm_TeklifSonAdim"];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListNonWorkship();
            if (items != null)
            {
                foreach (MaterialList materialList in items)
                {
                    MaterialListProvider.Instance.Save(materialList);// materialListModel.Save();
                }
            }
            frm_MesajFormu frm = new frm_MesajFormu();
            frm.lblMesaj.Text = "Malzemeler Kaydedildi...";
            frm.ShowDialog();
            this.Close();
            frm_Teklif_Adim3 a3 = (frm_Teklif_Adim3)Application.OpenForms["frm_Teklif_Adim3"];
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];

            if (CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).Count() == 0)
            {
                if (a4 == null)
                {
                    a4 = new frm_TeklifAdimSon();
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
            else
            {
                if (a3 == null)
                {
                    a3 = new frm_Teklif_Adim3();
                    a3.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                    a3.FormClosed += new FormClosedEventHandler(a3_FormClosed);
                    af.MainPanel.Visible = false;
                    a3.Show();

                }
                else
                {
                    a3.Activate();
                }
            }
        }
        private void a4_FormClosed(object sender, FormClosedEventArgs e)
        {
            a4 = null;
        }
        private void a3_FormClosed(object sender, FormClosedEventArgs e)
        {
            a3 = null;
        }

        private void gridViewTenderGroup_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.gridviewTenderGroupSelectedRow();
        }

        private void rpstColId_CheckedChanged(object sender, EventArgs e)
        {
            this.gridviewTenderGroupSelectedRow();
        }

        private void gridviewTenderGroupSelectedRow()
        {
            for (int i = 0; i < gridViewTenderGroup.RowCount; i++)
            {
                gridViewTenderGroup.SetRowCellValue(i, colSelectedId, false);
            }
            gridViewTenderGroup.SetFocusedRowCellValue("SelectedId", true);
            this.SelectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            this.LoadTenderMaterialList();
        }

        public void LoadTenderMaterialList()
        {
            if (this.SelectedGroupId != 0 && CurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialListNonWorkship.DataSource = models;
            }
        }
    }
}