using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IhalematikProBL.Entity;
using IhalematikPro.Manager;
using IhalematikPro.Model;
using IhalematikProUI.Model;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms.Base;
using IhalematikProUI.Forms.IhaleAdim;
using IhalematikProUI.Forms.Genel;
using IhalematikProUI.Report;
using DevExpress.XtraReports.UI;
using IhalematikProUI.Forms;
using System.Diagnostics;
using IhalematikProUI.Manager;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim3 : IhalematikBaseForm
    {
        public int FocusedRowHandle = 0;

        #region Variables
        private object a4;
        public MaterialListModel SelectedMaterial = null;
        private object a5;
        public int SelectedGroupId { get; set; }
        #endregion

        #region initialize
        public frm_Teklif_Adim3()
        {
            InitializeComponent();
            base.ScreenMethod();
        }
        private void frm_Teklif_Adim3_Load(object sender, EventArgs e)
        {
            if (CurrentManager.Instance.CurrentTender != null)
            {
                this.WorkerVehiclePanelCenter();
                lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
                lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            }
        }

        private void WorkerVehiclePanelCenter()
        {
            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (isciAracGirisPaneli.Width / 2);
        }

        #endregion

        #region Custom Methods
        public void panelKapat()
        {
            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Visible = false;
            grdMaterialListIsWorkship.Enabled = true;
            panelControl1.Enabled = true;
            grdMaterialListIsWorkship.EmbeddedNavigator.Enabled = true;
            panelControl1.Enabled = true;
            panelGrup.Enabled = true;
            panelControl3.Enabled = true;
            panelControl4.Enabled = true;
        }
        public void panelAc()
        {
            txtCurrentNumber.Text = this.SelectedMaterial.PozOBFNumber;
            txtCurrentDescription.Text = this.SelectedMaterial.PozOBFDescription;
            txtCurrentQuantity.Text = this.SelectedMaterial.Quantity.ToString();
            txtCurrentUnit.Text = this.SelectedMaterial.PozOBFUnit;

            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Visible = true;
            grdMaterialListIsWorkship.Enabled = false;
        }

        private List<DropDownModel> GetUnitTimes()
        {
            List<DropDownModel> models = new List<DropDownModel>();

            foreach (UnitTimeTypesEnum unitTimeType in Enum.GetValues(typeof(UnitTimeTypesEnum)))
            {
                DropDownModel model = new DropDownModel();//.Create(unitTimeType);
                model.Id = (int)unitTimeType;
                model.Text = this.GetUnitTimeTypesDisplayText(unitTimeType);
                models.Add(model);
            }

            return models;
        }
        private string GetUnitTimeTypesDisplayText(UnitTimeTypesEnum UnitTimeType)
        {
            string displayText = string.Empty;
            switch (UnitTimeType)
            {
                case UnitTimeTypesEnum.Minute:
                    displayText = "Dakika";
                    break;
                case UnitTimeTypesEnum.Hour:
                    displayText = "Saat";
                    break;
                case UnitTimeTypesEnum.Day:
                    displayText = "Gün";
                    break;
                case UnitTimeTypesEnum.Week:
                    displayText = "Hafta";
                    break;
                case UnitTimeTypesEnum.Month:
                    displayText = "Ay";
                    break;
                case UnitTimeTypesEnum.Year:
                    displayText = "Yıl";
                    break;
                default:
                    break;
            }

            return displayText;
        }
        #endregion

        #region Form Event

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            grdMaterialListIsWorkship.Refresh();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonAktif();
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text.Replace("%", ""));
            List<MaterialListModel> models = grdMaterialListIsWorkship.DataSource as List<MaterialListModel>;
            models.ForEach(p => p.WorkerPercentageMarkup = markup);
            foreach (var model in models)
            {
                MaterialList item = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.Id == model.Id).FirstOrDefault();
                item.WorkerMarkup = markup;
                MaterialListProvider.Instance.Save(item);
            }
            grdMaterialListIsWorkship.DataSource = null;
            grdMaterialListIsWorkship.DataSource = models;
            this.CalculateInnerValuesMarkup(models);
        }

        private void btnPanelKapat_Click(object sender, EventArgs e)
        {
            panelKapat();
            grdMaterialListIsWorkship.Refresh();
        }

        #endregion

        #region GridMaterialList
        private void btnCalisanlarveAraclar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        #endregion

        #region GridAddWorker Event

        private void LoadWorkerMateriallistGrid()
        {
            List<TenderMaterialListEquipmentModel> tenderMaterialListEquipmentModels = new List<TenderMaterialListEquipmentModel>();

            this.SelectedMaterial.TenderEquipments = null;
            this.SelectedMaterial.TenderMaterialListEquipment = null;
            List<TenderEquipment> a = this.SelectedMaterial.TenderEquipments;
            if (this.SelectedMaterial.TenderMaterialListEquipment != null)
            {
                foreach (TenderMaterialListEquipment tenderMaterialListEquipment in this.SelectedMaterial.TenderMaterialListEquipment)
                {
                    TenderMaterialListEquipmentModel tenderMaterialListEquipmentModel = new TenderMaterialListEquipmentModel(tenderMaterialListEquipment);
                    tenderMaterialListEquipmentModels.Add(tenderMaterialListEquipmentModel);
                }
            }

            bindingSourceAddWorker.DataSource = tenderMaterialListEquipmentModels.Where(p => p.Equipment.IsWorker);
            bindingSourceAddVehicle.DataSource = tenderMaterialListEquipmentModels.Where(p => !p.Equipment.IsWorker);
        }
        #endregion

        private void A5_FormClosed(object sender, FormClosedEventArgs e)
        {
            a5 = null;
        }

        public void LoadTenderGroupGrid()
        {
            //List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            List<TenderGroup> tenderGroupItems = new List<TenderGroup>();

            var items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).GroupBy(p => p.TenderGroup).ToList();

            if (items != null)
            {
                foreach (var item in items)
                {
                    TenderGroup tenderGroup = item.Key as TenderGroup;
                    tenderGroupItems.Add(tenderGroup);
                }
            }

            List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(tenderGroupItems);
            if (models.Count != 0)
            {
                grdTenderGroup.DataSource = models;
                models[0].IsSelected = true;
                this.SelectedGroupId = models[0].Id.Value;
                this.LoadTenderMaterialList();
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
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId && p.IsWorkship).ToList();
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialListIsWorkship.DataSource = models;
                gridViewMaterialListIsWorkship.FocusedRowHandle = this.FocusedRowHandle;

                this.CalculateInnerValuesMarkup(models);
            }
        }

        private void rpstIsSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewTenderGroup.RowCount; i++)
            {
                gridViewTenderGroup.SetRowCellValue(i, colIsSelected, false);
            }
            gridViewTenderGroup.SetFocusedRowCellValue(colIsSelected, true);
            this.SelectedGroupId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewTenderGroup.GetFocusedRowCellValue("Id"));
            LoadTenderMaterialList();
        }

        private void frm_Teklif_Adim3_Shown(object sender, EventArgs e)
        {
            bindingSourceAddWorker.DataSource = typeof(List<TenderMaterialListEquipmentModel>);
            this.LoadTenderGroupGrid();
            if (CurrentManager.Instance.CurrentTender.PersonHour)
            {
                //cmbAdamSaat.PerformClick();
            }
            else
            {
                //cmbBirimFiyat.PerformClick();
            }
        }

        private void CalculateInnerValuesMarkup(List<MaterialListModel> items)
        {
            if (items == null)
            {
                items = grdMaterialListIsWorkship.DataSource as List<MaterialListModel>;
            }
            if (items == null)
            {
                return;
            }
            if (cmbAdamSaat.Checked)
            {
                lblKarToplam.Text = (Math.Round(items.Sum(p => p.TotalWorkerMarkup), 2)).ToString("c2");
            }
            else
            {
                lblKarToplam.Text = (Math.Round(items.Sum(p => p.CustomWorkerMarkup * p.Quantity), 2)).ToString("c2");
            }
        }

        private void gridViewMaterialListIsWorkship_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colMaterialListMarkup)
            {
                int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialListIsWorkship.GetFocusedRowCellValue("Id"));
                foreach (var item in CurrentManager.Instance.CurrentTender.MaterialList)
                {
                    if (item.Id.Equals(currenMaterialId))
                    {
                        item.WorkerMarkup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                        List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId && p.IsWorkship).ToList();
                        foreach (var materialList in items)
                        {
                            MaterialListProvider.Instance.Save(materialList);
                        }
                        List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                        this.CalculateInnerValuesMarkup(models);
                        break;
                    }
                }
            }

            if (e.Column == colCustomWorkerUnitPrice)
            {
                int currenMaterialId = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewMaterialListIsWorkship.GetFocusedRowCellValue("Id"));
                foreach (var item in CurrentManager.Instance.CurrentTender.MaterialList)
                {
                    if (item.Id.Equals(currenMaterialId))
                    {
                        item.CustomWorkerUnitPrice = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
                        MaterialListProvider.Instance.Save(item);
                        break;
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.WorkerMarkup == 0 && p.IsWorkship).ToList();

            if (items != null && items.Count != 0)
            {
                DialogResult resultMsg = MessageBox.Show("İşçilik kari belirtmediginiz malzemeler var emin misiniz? ", "Yeni ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultMsg.Equals(DialogResult.Yes))
                {
                    this.Close();
                    frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                    af.RibonPasif();
                    af.btnAdimx5.PerformClick();
                }
            }
            else
            {
                bool personHour = cmbAdamSaat.Checked ? true : false;

                CurrentManager.Instance.CurrentTender.PersonHour = personHour;
                TenderProvider.Instance.Save(CurrentManager.Instance.CurrentTender);

                this.Close();
                frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                af.RibonPasif();
                af.btnAdimx5.PerformClick();
            }
        }
        private void a4_FormClosed(object sender, FormClosedEventArgs e)
        {
            a4 = null;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            panelKapat();
            this.LoadTenderMaterialList();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            af.RibonPasif();
            af.btnAdimx4.PerformClick();
        }

        private void txtWorkerMarkup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTumuneUygula.PerformClick();
            }
        }

        private void txtWorkerMarkup_TextChanged(object sender, EventArgs e)
        {
            //SAMET ekledi
            {
                string tString = txtWorkerMarkup.Text;
                if (tString.Trim() == "") return;
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Lütfen Sadece Rakam Giriniz...");
                        txtWorkerMarkup.Text = "";
                        return;
                    }
                }
            }
        }

        private void cmbAdamSaat_Click(object sender, EventArgs e)
        {
            //clmEquipments.Visible = true;
            //colWorkerUnitPrice.VisibleIndex = 6;
            //colWorkerTotalAmount.VisibleIndex = 7;
            //colWorkerMarkupUnitPrice.VisibleIndex = 8;
            //colCustomWorkerUnitPrice.Visible = false;
            //colCustomWorkerTotalAmount.Visible = false;
            //colCustomWorkerMarkupUnitPrice.Visible = false;
            //colWorkerUnitPrice.Visible = true;
            //colWorkerTotalAmount.Visible = true;
            //colWorkerMarkupUnitPrice.Visible = true;
            //this.CalculateInnerValuesMarkup(null);
        }

        private void cmbBirimFiyat_Click(object sender, EventArgs e)
        {
        //    colCustomWorkerUnitPrice.VisibleIndex = 6;
        //    colCustomWorkerTotalAmount.VisibleIndex = 7;
        //    colCustomWorkerMarkupUnitPrice.VisibleIndex = 8;
        //    clmEquipments.Visible = false;
        //    colCustomWorkerUnitPrice.Visible = true;
        //    colCustomWorkerTotalAmount.Visible = true;
        //    colCustomWorkerMarkupUnitPrice.Visible = true;
        //    colWorkerUnitPrice.Visible = false;
        //    colWorkerTotalAmount.Visible = false;
        //    colWorkerMarkupUnitPrice.Visible = false;
        //    this.CalculateInnerValuesMarkup(null);
        }

        private void btnCalisanlarveAraclar_Click(object sender, EventArgs e)
        {
            frm_Iscilik iscilik = new frm_Iscilik(this);

            bindingSourceAddWorker.DataSource = null;
            int currentId = Convert.ToInt32(gridViewMaterialListIsWorkship.GetFocusedRowCellValue("Id"));
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.IsWorkship).ToList();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            foreach (var item in models)
            {
                if (item.Id == currentId)
                {
                    this.SelectedMaterial = item;
                    //this.panelAc();
                    LoadWorkerMateriallistGrid();
                    break;
                }
            }
            this.FocusedRowHandle = gridViewMaterialListIsWorkship.FocusedRowHandle;
            iscilik.SelectedMaterial = this.SelectedMaterial;
            iscilik.ShowDialog();
        }

        private void cmbAdamSaat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p =>  p.IsWorkship).ToList();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            grdMaterialListIsWorkship.DataSource = models;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            IscilikMaliyetKarRaporu ikr = new IscilikMaliyetKarRaporu();
            ReportPrintTool tool = new ReportPrintTool(ikr);
            ikr.ShowPreview();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
          try
            {
                bool isSuccess = UIReportManager.Instance.ExtractExcel(grdMaterialListIsWorkship);
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
