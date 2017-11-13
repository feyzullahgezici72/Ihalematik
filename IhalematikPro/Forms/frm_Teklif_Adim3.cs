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
using IhalematikPro.Manager;
using IhalematikPro.Model;
using DevExpress.XtraEditors.Repository;
using System.Reflection;
using System.Dynamic;
using System.Threading;
using System.Reflection.Emit;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using IhalematikProUI.Model;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using IhalematikProUI.Forms;
using SimpleApplicationBase.BL.Base;

namespace IhalematikPro.Forms
{
    public partial class frm_Teklif_Adim3 : DevExpress.XtraEditors.XtraForm
    {
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
            bindingSourceAddWorker.DataSource = typeof(List<TenderMaterialListEquipmentModel>);
            grdAddWorker.DataSource = bindingSourceAddWorker;
            grdAddVehicle.DataSource = bindingSourceAddVehicle;
        }
        private void frm_Teklif_Adim3_Load(object sender, EventArgs e)
        {
            //panel
            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (isciAracGirisPaneli.Width / 2);
            //panel 
            lblTenderDescription.Text = CurrentManager.Instance.CurrentTender.Description;
            lblTenderNumber.Text = CurrentManager.Instance.CurrentTender.DisplayNumber;
            //List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            //List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            //grdMaterialListIsWorkship.DataSource = models;

            #region repostryWorkers
            List<DropDownModel> workers = UIWorkerManager.Instance.GetDropDownWorkers();
            rpstWorker.DataSource = workers;
            rpstWorker.DisplayMember = "Text";
            rpstWorker.ValueMember = "Id";
            rpstWorker.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            rpstWorker.NullText = string.Empty;
            rpstWorker.ForceInitialize();
            rpstWorker.PopulateColumns();
            //rpstWorker2.GetDataSourceValue();
            rpstWorker.Properties.Columns["Id"].Visible = false;
            //rpstWorker2.Properties.Columns["Self"].Visible = false;
            rpstWorker.ShowHeader = false;
            #endregion

            #region repostryVehicles
            List<DropDownModel> vehicles = UIVehicleManager.Instance.GetDropDownVehicles();
            rpstVehicle.DataSource = vehicles;
            rpstVehicle.DisplayMember = "Text";
            rpstVehicle.ValueMember = "Id";
            rpstVehicle.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            rpstVehicle.NullText = string.Empty;
            rpstVehicle.ForceInitialize();
            rpstVehicle.PopulateColumns();
            //rpstWorker2.GetDataSourceValue();
            rpstVehicle.Properties.Columns["Id"].Visible = false;
            //rpstWorker2.Properties.Columns["Self"].Visible = false;
            rpstVehicle.ShowHeader = false;
            #endregion

            this.LoadTenderGroupGrid();
            this.CalculateInnerValuesMarkup();
        }

        #endregion

        #region Custom Methods
        public void panelKapat()
        {
            isciAracGirisPaneli.Top = 0;
            isciAracGirisPaneli.Visible = false;
            grdMaterialListIsWorkship.Enabled = true;
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

            //grdAddWorker.DataSource = CurrentItem.TenderMaterialListEquipment;
        }

        private List<UnitTimeTypesModel> GetUnitTimes()
        {
            List<UnitTimeTypesModel> models = new List<UnitTimeTypesModel>();

            foreach (UnitTimeTypesEnum unitTimeType in Enum.GetValues(typeof(UnitTimeTypesEnum)))
            {
                UnitTimeTypesModel model = new UnitTimeTypesModel().Create(unitTimeType);
                models.Add(model);
            }

            return models;
        }


        private void CalculateInnerValuesMarkup()
        {
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            txtBaseAmount.Text = models.Sum(p => p.Quantity * p.WorkerUnitPrice).ToString("c2");
            txtMarkupAmount.Text = models.Sum(p => p.MarkupUnitPrice).ToString("c2");
            txtTotalAmount.Text = models.Sum(p => (p.Quantity * p.WorkerUnitPrice) + p.MarkupUnitPrice).ToString("c2");
        }

        #endregion

        #region Form Event

        private void btnTumuneUygulaIscilik_Click(object sender, EventArgs e)
        {
            //double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text);
            //List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            //List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            //models.ForEach(p => p.Markup = markup);
            //foreach (var item in items)
            //{
            //    item.Markup = markup;
            //    OperationResult result = MaterialListProvider.Instance.Save(item);
            //    if (!result.Success)
            //    {
            //        //TODO feyzullahg
            //    }
            //}
            //grdMaterialListIsWorkship.DataSource = models;
            //grdMaterialListIsWorkship.Refresh();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            foreach (MaterialListModel materialListModel in models)
            {
                materialListModel.Save();

                //foreach (TenderMaterialListEquipment tenderMaterialListEquipment in materialListModel.TenderMaterialListEquipment)
                //{
                //    TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
                //}
            }
            frm_ihaleOlustuMesaj msj = new frm_ihaleOlustuMesaj();
            msj.lblMesaj.Text = "Kaydedildi...";
            msj.ShowDialog();
            this.Close();


            frm_TeklifAdimSon a4 = (frm_TeklifAdimSon)Application.OpenForms["frm_TeklifSonAdim"];
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
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

        private void a4_FormClosed(object sender, FormClosedEventArgs e)
        {
            a4 = null;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            grdMaterialListIsWorkship.Refresh();
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            double markup = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(txtWorkerMarkup.Text.Replace("%", ""));
            List<MaterialList> items = UIMaterialListManager.Instance.GetMaterialListIsWorkship();
            List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
            models.ForEach(p => p.Markup = markup);
            foreach (var item in items)
            {
                item.WorkerMarkup = markup;
                OperationResult result = MaterialListProvider.Instance.Save(item);
                if (!result.Success)
                {
                    //TODO feyzullahg
                }
            }
            this.frm_Teklif_Adim3_Load(null, null);
        }

        private void btnPanelKapat_Click(object sender, EventArgs e)
        {
            panelKapat();
            grdMaterialListIsWorkship.Refresh();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            panelKapat();
        }

        #endregion

        #region GridMaterialList
        private void btnCalisanlarveAraclar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            bindingSourceAddWorker.DataSource = null;
            int currentId = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            List<MaterialListModel> models = grdMaterialListIsWorkship.DataSource as List<MaterialListModel>;
            foreach (var item in models)
            {
                if (item.Id == currentId)
                {
                    this.SelectedMaterial = item;
                    this.panelAc();
                    LoadWorkerMateriallistGrid();
                    break;
                }
            }
        }
        #endregion

        #region GridAddWorker Event

        private void gridViewAddWorker_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colAddWorkerId || e.Column == colAddWorkerWorkerUnitPrice)
            {
                return;
            }
            TenderMaterialListEquipmentModel currentItem = new TenderMaterialListEquipmentModel();
            int currentId = Convert.ToInt32(gridViewAddWorker.GetFocusedRowCellValue("Id"));
            if (currentId <= 0)
            {
                currentItem = new TenderMaterialListEquipmentModel();
                TenderEquipment equipment = new TenderEquipment();
                equipment.IsWorker = true;
                equipment.TenderId = CurrentManager.Instance.CurrentTender.Id;
                if (e.Column == colAddWorkerWorker)
                {
                    object b = gridViewAddWorker.ActiveEditor.EditValue;
                    equipment.WorkerVehicleId = (int)b;
                }
                OperationResult result = TenderEquipmentProvider.Instance.Save(equipment);
                if (result.Success)
                {
                    TenderMaterialListEquipment tenderMaterialListEquipment = new TenderMaterialListEquipment();
                    tenderMaterialListEquipment.EquipmentId = equipment.Id;
                    tenderMaterialListEquipment.MaterialListId = this.SelectedMaterial.Id.Value;
                    tenderMaterialListEquipment.TenderId = CurrentManager.Instance.CurrentTender.Id;
                    tenderMaterialListEquipment.Equipment = equipment;
                    OperationResult result1 = TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
                    if (result1.Success)
                    {
                        currentItem = new TenderMaterialListEquipmentModel(tenderMaterialListEquipment);
                        currentItem.Equipment = equipment;
                        gridViewAddWorker.SetFocusedRowCellValue(colAddWorkerId, currentItem.Id);
                        LoadWorkerMateriallistGrid();
                        return;
                    }
                }
            }
            else
            {
                List<TenderMaterialListEquipmentModel> items = ((IEnumerable<TenderMaterialListEquipmentModel>)bindingSourceAddWorker.DataSource).ToList();

                foreach (TenderMaterialListEquipmentModel item in items)
                {
                    if (item.Id == currentId)
                    {
                        currentItem = item;
                        break;
                    }
                }
            }

            if (e.Column == colAddWorkerQuantity)
            {
                currentItem.Quantity = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
            }
            else if (e.Column == colAddWorkerUnitTime)
            {
                currentItem.UnitTime = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(e.Value);
            }
            else if (e.Column == colAddWorkerUnitTimeType)
            {
                currentItem.UnitTimeType = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<UnitTimeTypesEnum>(e.Value);
            }

            else if (e.Column == colAddWorkerWorker)
            {
                currentItem.Equipment.WorkerVehicleId = (int)e.Value;
                TenderEquipmentProvider.Instance.Save(currentItem.Equipment);
                currentItem.Equipment = null;
            }

            currentItem.Save();
            grdAddWorker.Refresh();
        }

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

        private void gridViewAddVehicle_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colAddVehicleId || e.Column == colAddVehicleWorkerUnitPrice)
            {
                return;
            }
            TenderMaterialListEquipmentModel currentItem = new TenderMaterialListEquipmentModel();
            int currentId = Convert.ToInt32(gridViewAddVehicle.GetFocusedRowCellValue("Id"));
            if (currentId <= 0)
            {
                //if (e.Value == null)
                //{
                //    return;
                //}
                currentItem = new TenderMaterialListEquipmentModel();
                TenderEquipment equipment = new TenderEquipment();
                equipment.IsWorker = false;
                equipment.TenderId = CurrentManager.Instance.CurrentTender.Id;
                if (e.Column == colAddVehicleVehicle)
                {
                    //System.Data.DataRow row = gridViewAddVehicle.GetDataRow(gridViewAddVehicle.FocusedRowHandle);
                    //string cellValue = row[0].ToString();
                    //object a = gridViewAddVehicle.GetSelectedRow("SelectedVehicle");
                    object b = gridViewAddVehicle.ActiveEditor.EditValue;
                    equipment.WorkerVehicleId = (int)b;
                }
                OperationResult result = TenderEquipmentProvider.Instance.Save(equipment);
                if (result.Success)
                {
                    TenderMaterialListEquipment tenderMaterialListEquipment = new TenderMaterialListEquipment();
                    tenderMaterialListEquipment.EquipmentId = equipment.Id;
                    tenderMaterialListEquipment.MaterialListId = this.SelectedMaterial.Id.Value;
                    tenderMaterialListEquipment.TenderId = CurrentManager.Instance.CurrentTender.Id;
                    tenderMaterialListEquipment.Equipment = equipment;
                    OperationResult result1 = TenderMaterialListEquipmentProvider.Instance.Save(tenderMaterialListEquipment);
                    if (result1.Success)
                    {
                        currentItem = new TenderMaterialListEquipmentModel(tenderMaterialListEquipment);
                        currentItem.Equipment = equipment;
                        gridViewAddVehicle.SetFocusedRowCellValue(colAddVehicleId, currentItem.Id);
                        LoadWorkerMateriallistGrid();
                        return;
                    }
                }
            }
            else
            {
                List<TenderMaterialListEquipmentModel> items = ((IEnumerable<TenderMaterialListEquipmentModel>)bindingSourceAddVehicle.DataSource).ToList();

                foreach (TenderMaterialListEquipmentModel item in items)
                {
                    if (item.Id == currentId)
                    {
                        currentItem = item;
                        break;
                    }
                }
            }

            if (e.Column == colAddVehicleQuantity)
            {
                currentItem.Quantity = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<double>(e.Value);
            }
            else if (e.Column == colAddVehicleUnitTime)
            {
                currentItem.UnitTime = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(e.Value);
            }
            else if (e.Column == colAddVehicleUnitTimeType)
            {
                currentItem.UnitTimeType = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<UnitTimeTypesEnum>(e.Value);
            }

            else if (e.Column == colAddVehicleVehicle)
            {
                currentItem.Equipment.WorkerVehicleId = (int)e.Value;
                TenderEquipmentProvider.Instance.Save(currentItem.Equipment);
                currentItem.Equipment = null;
            }

            currentItem.Save();
            grdAddVehicle.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
             this.Close();

            frm_IscilikFirimFiyat a5 = (frm_IscilikFirimFiyat)Application.OpenForms["frm_IscilikFirimFiyat"];
            frm_Anaform af = (frm_Anaform)Application.OpenForms["frm_Anaform"];
            if (a5 == null)
            {
                a5 = new frm_IscilikFirimFiyat();
                a5.MdiParent = (frm_Anaform)Application.OpenForms["frm_Anaform"];
                a5.FormClosed +=new FormClosedEventHandler(A5_FormClosed);
                af.MainPanel.Visible = false;
                a5.Show();
                
            }
            else
            {
                a5.Activate();
            }
           
        }

        private void A5_FormClosed(object sender, FormClosedEventArgs e)
        {
            a5 = null;
        }

        public void LoadTenderGroupGrid()
        {
            List<TenderGroup> items = TenderGroupProvider.Instance.GetItems("TenderId", CurrentManager.Instance.CurrentTender.Id);
            List<TenderGroupModel> models = IhalematikModelBase.GetModels<TenderGroupModel, TenderGroup>(items);
            grdTenderGroup.DataSource = models;
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
                List<MaterialList> items = CurrentManager.Instance.CurrentTender.MaterialList.Where(p => p.TenderGroupId == this.SelectedGroupId && p.IsWorkship).ToList();
                List<MaterialListModel> models = IhalematikModelBase.GetModels<MaterialListModel, MaterialList>(items);
                grdMaterialListIsWorkship.DataSource = models;
            }
        }
    }
}