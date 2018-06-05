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
using IhalematikProUI.Forms.Genel;
using IhalematikProUI.Report;
using DevExpress.XtraReports.UI;
using System.Diagnostics;
using IhalematikProUI.Manager;
using IhalematikProBL.Manager;

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
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                lblTenderDescription.Text = UICurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = UICurrentManager.Instance.CurrentTender.DisplayNumber;
            }
        }
        private void CalculateTotalMarkup()
        {
            //List<MaterialListModel> items = grdMaterialListNonWorkship.DataSource as List<MaterialListModel>;
            //if (items != null)
            //{
            //    //List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            //    //double baseAmount = 0;
            //    //lblTotalMarkup.Text = (items.Sum(p => p.TotalMarkup)).ToString("C2");
            //}
        }

        public void LoadTenderGroupGrid()
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", UICurrentManager.Instance.CurrentTender.Id);
                List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);
                if (models != null && models.Count != 0)
                {
                    models[0].IsSelected = true;
                    this.SelectedGroupId = models[0].Id.Value;
                    grdTenderGroup.DataSource = models;
                    this.LoadTenderMaterialList();
                }
            }
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRisk.Text) || !string.IsNullOrEmpty(txtMarkup.Text))
            {
                double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtMarkup.Text.Replace("%", ""));
                double risk = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtRisk.Text.Replace("%", ""));

                List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
                foreach (var item in items)
                {
                    if (!string.IsNullOrEmpty(txtMarkup.Text))
                    {
                        item.Markup = markup;
                    }
                    if (!string.IsNullOrEmpty(txtRisk.Text))
                    {
                        item.Risk = risk;
                    }
                    MaterialListProvider.Instance.Save(item);
                }
                this.LoadTenderMaterialList();
                this.CalculateTotalMarkup();
                UIPopupManager.Instance.ShowPopup();
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colMarkup)
            {
                int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialListNonWorkship.GetFocusedRowCellValue("Id"));
                foreach (var item in UICurrentManager.Instance.CurrentTender.MaterialList)
                {
                    if (item.Id.Equals(currenMaterialId))
                    {
                        item.Markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                        break;
                    }
                }
            }
            if (e.Column == colRisk)
            {
                int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialListNonWorkship.GetFocusedRowCellValue("Id"));
                foreach (var item in UICurrentManager.Instance.CurrentTender.MaterialList)
                {
                    if (item.Id.Equals(currenMaterialId))
                    {
                        item.Risk = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                        break;
                    }
                }
            }
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
            if (this.SelectedGroupId != 0 && UICurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                LoadingManager.Instance.Show(this);
                List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                LoadingManager.Instance.Hide();
                grdMaterialListNonWorkship.DataSource = models;
                this.CalculateTotalMarkup();
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
            this.Enabled = false;
           
            bindingSourceMaterialListNonWorkship.DataSource = typeof(List<MaterialListModel>);
            grdMaterialListNonWorkship.DataSource = bindingSourceMaterialListNonWorkship;
            this.LoadTenderGroupGrid();
            this.CalculateTotalMarkup();
            this.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.Markup == 0).ToList();

            if (items != null && items.Count != 0)
            {
                DialogResult resultMsg = MessageBox.Show("Malzeme kari belirtmediginiz malzemeler var emin misiniz? ", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMsg.Equals(DialogResult.Yes))
                {
                    this.Close();
                    if (UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).Count() == 0)
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
            }
            else
            {
                this.Close();
                if (UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).Count() == 0)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.SelectedGroupId != 0 && UICurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList;
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialListNonWorkship.DataSource = models;
                this.CalculateTotalMarkup();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialListNonWorkship);
                if (!isSuccess)
                {
                    MessageBox.Show("Program beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception ex)
            {
                LoggingManager.Instance.SaveErrorLog(ex);
            }
        }
    }
}