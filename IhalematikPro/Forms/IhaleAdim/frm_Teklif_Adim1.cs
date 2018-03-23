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
using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProUI.Report;
using IhalematikProUI.Model;
using DevExpress.XtraReports.UI;
using System.Threading;
using IhalematikProUI.Forms.Base;
using IhalematikPro.Forms;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.IhaleAdim;
using IhalematikProUI.Forms.Genel;
using IhalematikProBL.Enum;
using IhalematikProUI.Manager;
using IhalematikProUI.Forms;
using System.Diagnostics;
using System.IO;
//using IhalematikProUI.Report;
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
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void frm_Teklif_Adim1_Load(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentTender != null)
            {
                lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
                this.KeyPreview = true;
                this.KeyDown += new KeyEventHandler(Frm_Teklif_Adim1_KeyDown);
            }
        }
        public void LoadTenderGroupGrid()
        {
            Offer offer = CurrentManager.Instance.CurrentTender.Offer;
            Tender tender = CurrentManager.Instance.CurrentTender;
            if (tender != null)
            {
                List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
                List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);

                if (models != null && models.Count != 0)
                {
                    if (models.Count == 1 && offer != null)
                    {
                        List<MaterialList> addedMaterialLists = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => !p.IsPoz).ToList();

                        foreach (var item in offer.MaterialList)
                        {
                            MaterialList addedMaterialList = addedMaterialLists.Where(p => p.PozOBFId == item.PozOBFId && !p.IsPoz).FirstOrDefault();

                            if (addedMaterialList == null)
                            {
                                MaterialList materialList = new MaterialList();
                                materialList.IsPoz = false;
                                materialList.PozOBFId = item.PozOBFId;
                                materialList.Tender = tender;
                                materialList.TenderGroupId = models[0].Id.Value;
                                materialList.OfferPrice = item.Price;
                                materialList.KDVPercentage = 18;
                                MaterialListProvider.Instance.Save(materialList);
                            }
                        }
                    }

                    models[0].IsSelected = true;
                    grdTenderGroup.DataSource = models;
                    this.SelectedGroupId = models[0].Id.Value;
                    this.LoadTenderMaterialList();
                }
            }
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

        private void OpenForm2()
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonPasif();
            af.btnAdimx4.PerformClick();
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
            MaterialListModel selectedItem = gridViewMaterialList.GetRow(e.RowHandle) as MaterialListModel;

            //if (e.Column == colIsWorker)
            //{
            //    selectedItem.IsWorkship = true;
            //    MaterialListProvider.Instance.Save(selectedItem);
            //}//double baseAmount = CurrentManager.Instance.CurrentTender.MaterialList.Sum(p => p.TotalAmount);
            //double baseKDVAmount = CurrentManager.Instance.CurrentTender.MaterialList.Sum(p => p.KDVAmount);

            //txtBaseAmount.Text = string.Format("{0:C2}", baseAmount);
            //txtBaseKDVAmount.Text = string.Format("{0:C2}", baseKDVAmount);
            //txtTotalAmount.Text = string.Format("{0:C2}", Math.Round((baseKDVAmount + baseAmount), 2));
        }

        public void RefreshDataGrid()
        {
            if (this.SelectedGroupId != 0)
            {
                grdMaterialList.DataSource = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId);
                grdMaterialList.RefreshDataSource();
            }
        }

        private void gridViewTenderGroup_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.SaveMaterialListIsWorkship();
            for (int i = 0; i < gridViewTenderGroup.RowCount; i++)
            {
                gridViewTenderGroup.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewTenderGroup.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            this.LoadTenderMaterialList();
        }

        private void SaveMaterialListIsWorkship()
        {
            List<MaterialListModel> models = grdMaterialList.DataSource as List<MaterialListModel>;

            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;

            foreach (MaterialListModel model in models)
            {
                MaterialList item = items.Where(p => p.Id == model.Id).FirstOrDefault();
                if (item != null)
                {
                    item.Quantity = model.Quantity;
                    item.KDVPercentage = model.KDVPercentage;
                    item.IsWorkship = model.IsWorkship;
                    MaterialListProvider.Instance.Save(item);
                }
            }
        }

        public void LoadTenderMaterialList()
        {
            if (this.SelectedGroupId != 0 && CurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
                List<MaterialListModel> models = new List<MaterialListModel>();
                foreach (var item in items)
                {
                    MaterialListModel model = new MaterialListModel(item);
                    models.Add(model);
                }

                grdMaterialList.DataSource = models;
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

        private void frm_Teklif_Adim1_Shown(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentTender != null && CurrentManager.Instance.CurrentTender.Offer != null)
            {
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                colQuantity.OptionsColumn.ReadOnly = true;

                colKDV.OptionsColumn.AllowEdit = false;
                colKDV.OptionsColumn.AllowFocus = false;
                colKDV.OptionsColumn.ReadOnly = true;
            }
            this.LoadTenderGroupGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            this.SaveMaterialListIsWorkship();

            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).ToList();

            List<MaterialList> zeroAmountItems = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.Quantity == 0).ToList();

            if (zeroAmountItems != null && zeroAmountItems.Count != 0)
            {
                MessageBox.Show("Miktarı 0 olan malzeme bıraktınız. Lütfen miktar belirtiniz?");
                return;
            }
            if (items != null && items.Count == 0)
            {
                DialogResult resultMsg = MessageBox.Show("Hiç işçilikli malzeme seçmediniz eminmisiniz?", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMsg.Equals(DialogResult.Yes))
                {
                    this.OpenForm2();
                }
            }
            else
            {
                this.OpenForm2();
            }
        }

        private void btnSelectDeselect_Click(object sender, EventArgs e)
        {
            List<MaterialListModel> models = grdMaterialList.DataSource as List<MaterialListModel>;
            if (models != null && models.Count != 0)
            {
                if (models.Where(p => !p.IsWorkship).Count() == 0)
                {
                    models.ForEach(p => p.IsWorkship = false);
                }
                else
                {
                    models.ForEach(p => p.IsWorkship = true);
                }
                grdMaterialList.DataSource = models;
                grdMaterialList.RefreshDataSource();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList;
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialList.DataSource = models;
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialList);
                if (!isSuccess)
                {
                    MessageBox.Show("Hay Aksii!! \nProgram beklenmeyen bir hata ile karşılaştı.");
                }
            }
            catch (Exception)
            {

                
            }

        }
    }
}