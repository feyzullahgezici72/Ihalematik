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
using System.Threading;
using IhalematikProUI.Forms.Base;
using DevExpress.XtraBars;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim2 : IhalematikBaseForm
    {
        private object a3;
        public int SelectedGroupId { get; set; }

        public frm_Teklif_Adim2()
        {
            InitializeComponent();
            base.ScreenMethod();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void frm_Teklif_Adim2_Load(object sender, EventArgs e)
        {
            lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
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
            models[0].IsSelected = true;
            this.SelectedGroupId = models[0].Id.Value;
            grdTenderGroup.DataSource = models;
            this.LoadTenderMaterialList();
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMarkup.Text.Replace("%", ""));
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
            foreach (var item in items)
            {
                item.Markup = markup;
                //MaterialListProvider.Instance.Save(item);
            }
            this.LoadTenderMaterialList();
            this.CalculateTotalMarkup();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colMarkup)
            {
                int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialListNonWorkship.GetFocusedRowCellValue("Id"));
                foreach (var item in CurrentManager.Instance.CurrentTender.MaterialList)
                {
                    if (item.Id.Equals(currenMaterialId))
                    {
                        item.Markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                        break;
                    }
                }
                double baseAmount = 0;
                this.CalculateInnerValue(ref baseAmount);
            }
        }

        private void CalculateInnerValue(ref double BaseAmount)
        {
            //List<MaterialListModel> items = grdMaterialListNonWorkship.DataSource as List<MaterialListModel>;//CurrentManager.CurrentTender.MaterialList;//.Instance.GetMaterialListNonWorkship();
            //if (items != null)
            //{
            //    BaseAmount = items.Sum(p => p.Markup * p.Quantity);
            //    double baseKDVAmount = items.Sum(p => p.KDVAmount);

            //    txtBaseAmount.Text = string.Format("{0:C2}", BaseAmount);
            //    txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
            //    txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + BaseAmount), 2));

            //    lblTotalMarkup.Text = (items.Sum(p => p.TotalMarkup)).ToString("C2");
            //}
        }
        frm_TeklifAdimSon a4 = (frm_TeklifAdimSon)Application.OpenForms["frm_TeklifSonAdim"];

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
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialListNonWorkship.DataSource = models;
            }
        }

        private void rpstColIsSelected_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewTenderGroup.RowCount; i++)
            {
                gridViewTenderGroup.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewTenderGroup.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            LoadTenderMaterialList();
        }

        private void frm_Teklif_Adim2_Shown(object sender, EventArgs e)
        {
            bindingSourceMaterialListNonWorkship.DataSource = typeof(List<MaterialListModel>);
            grdMaterialListNonWorkship.DataSource = bindingSourceMaterialListNonWorkship;
            this.LoadTenderGroupGrid();
            this.CalculateTotalMarkup();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();


            if (CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).Count() == 0)
            {
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                af.RibonPasif();
                af.btnAdimx5.PerformClick();
            }
            else
            {
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                af.RibonPasif();
                af.btnAdimx3.PerformClick();
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonPasif();
            af.btnAdimx1.PerformClick();
        }

        private void txtMarkup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTumuneUygula.PerformClick();
            }
        }

        private void txtMarkup_TextChanged(object sender, EventArgs e)
        {
            //SAMET ekledi
            {
                string tString = txtMarkup.Text;
                if (tString.Trim() == "") return;
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Lütfen Sadece Rakam Giriniz...");
                        txtMarkup.Text = "";
                        return;
                    }
                }
            }
        }
    }
}