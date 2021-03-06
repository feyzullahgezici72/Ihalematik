﻿using System;
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
using IhalematikProBL.Manager;
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
            this.SaveMaterialListIsWorkship();
        }

        private void frm_Teklif_Adim1_Load(object sender, EventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender != null)
            {
                lblTenderDescription.Text = UICurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = UICurrentManager.Instance.CurrentTender.DisplayNumber;
                this.KeyPreview = true;
                this.KeyDown += new KeyEventHandler(Frm_Teklif_Adim1_KeyDown);
            }
        }
        public void LoadTenderGroupGrid()
        {
            Offer offer = UICurrentManager.Instance.CurrentTender.Offer;
            Tender tender = UICurrentManager.Instance.CurrentTender;
            if (tender != null)
            {
                List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", UICurrentManager.Instance.CurrentTender.Id);
                List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);

                if (models != null && models.Count != 0)
                {
                    LoadingManager.Instance.Show(this);
                    if (models.Count == 1 && offer != null)
                    {
                        List<MaterialList> addedMaterialLists = UICurrentManager.Instance.CurrentTender.MaterialList.ToList();

                        foreach (var item in offer.MaterialList)
                        {
                            MaterialList addedMaterialList = addedMaterialLists.Where(p => p.PozOBFId == item.PozOBFId).FirstOrDefault();

                            if (addedMaterialList == null)
                            {
                                MaterialList materialList = new MaterialList();
                                materialList.IsPoz = item.IsPoz;
                                materialList.Quantity = item.Quantity;
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
            grdMaterialList.DataSource = UICurrentManager.Instance.CurrentTender.MaterialList;
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
                grdMaterialList.DataSource = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId);
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

            List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList;

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
            List<MaterialListModel> models = new List<MaterialListModel>();
            if (this.SelectedGroupId != 0 && UICurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId).ToList();
                foreach (var item in items)
                {
                    MaterialListModel model = new MaterialListModel(item);
                    models.Add(model);
                }

            }
            LoadingManager.Instance.Hide();
            grdMaterialList.DataSource = models;
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
            if (UICurrentManager.Instance.CurrentTender != null && UICurrentManager.Instance.CurrentTender.Offer != null)
            {
                colQuantity.OptionsColumn.AllowEdit = false;
                colQuantity.OptionsColumn.AllowFocus = false;
                colQuantity.OptionsColumn.ReadOnly = true;

                colKDV.OptionsColumn.AllowEdit = false;
                colKDV.OptionsColumn.AllowFocus = false;
                colKDV.OptionsColumn.ReadOnly = true;
                btnExceldenAl.Visible = false;
            }
            this.Enabled = false;
           // LoadingManager.Instance.Show(this);
            this.LoadTenderGroupGrid();
            //LoadingManager.Instance.Hide();;
            this.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender.MaterialList == null || UICurrentManager.Instance.CurrentTender.MaterialList.Count == 0)
            {
                MessageBox.Show("Liste boş yada miktar belirtmediğiniz malzemeler var");
                return;
            }

            this.SaveMaterialListIsWorkship();
            List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).ToList();

            List<MaterialList> zeroAmountItems = UICurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.Quantity == 0).ToList();

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
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialList);
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

     

        private void btnExceldenAl_Click(object sender, EventArgs e)
        {
            //frm_PozOrObfIhale pozorobf = new frm_PozOrObfIhale(this);
            //pozorobf.ShowDialog();
        }

        private void btnObf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_TopluObfYukleIhale obfY = new frm_TopluObfYukleIhale(this);
            obfY.ShowDialog();
        }

        private void btnPoz_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_TopluPozYukleIhale pozY = new frm_TopluPozYukleIhale(this);
            pozY.ShowDialog();
        }

      

        private void barbtnYeniGrup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_IhaleGrup ig = new frm_IhaleGrup(this);
            ig.ShowDialog();
        }

        private void barTumGrupListele_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (UICurrentManager.Instance.CurrentTender.MaterialList != null)
            {
                List<MaterialList> items = UICurrentManager.Instance.CurrentTender.MaterialList;
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialList.DataSource = models;
            }
        }

        private void btnBfGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

        }

        private void btGuncelle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frm_obfGuncelle obfG = (frm_obfGuncelle) Application.OpenForms["frm_obfGuncelle"];
            obfG.ShowDialog();

        }
    }
}