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
using IhalematikProUI.Model;
using IhalematikPro.Manager;
using IhalematikProBL.Enum;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Provider;
using IhalematikProBL.Entity;
using IhalematikPro.Model;
using IhalematikPro.Forms;

namespace IhalematikProUI.Forms.IhaleAdim
{
    public partial class frm_Iscilik : DevExpress.XtraEditors.XtraForm
    {
        frm_Teklif_Adim3 _owner = null;
        public MaterialListModel SelectedMaterial = null;

        public frm_Iscilik(frm_Teklif_Adim3 Owner)
        {
            this._owner = Owner;
            InitializeComponent();
        }

        private void btnPanelKapat_Click(object sender, EventArgs e)
        {
            this._owner.LoadTenderMaterialList();
            this.Close();
        }

        private void frm_Iscilik_Load(object sender, EventArgs e)
        {

        }

        private void frm_Iscilik_Shown(object sender, EventArgs e)
        {
            txtCurrentNumber.Text = this.SelectedMaterial.PozOBFNumber;
            txtCurrentDescription.Text = this.SelectedMaterial.PozOBFDescription;
            txtCurrentQuantity.Text = this.SelectedMaterial.Quantity.ToString();
            txtCurrentUnit.Text = this.SelectedMaterial.PozOBFUnit;

            grdAddWorker.DataSource = bindingSourceAddWorker;
            grdAddVehicle.DataSource = bindingSourceAddVehicle;
            this.RPSTWorkers();
            this.RPSTVehicles();
            this.RPSTWorkerUnitTimeTypes();
            this.RPSTVehicleUnitTimeTypes();
            this.LoadWorkerMateriallistGrid();
        }
        private void RPSTVehicles()
        {
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
        }

        private void RPSTVehicleUnitTimeTypes()
        {
            List<DropDownModel> unitTimes = this.GetUnitTimes();
            rpstVehicleUnitTimeTypes.DataSource = unitTimes;
            rpstVehicleUnitTimeTypes.DisplayMember = "Text";
            rpstVehicleUnitTimeTypes.ValueMember = "Id";
            rpstVehicleUnitTimeTypes.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            rpstVehicleUnitTimeTypes.NullText = string.Empty;
            rpstVehicleUnitTimeTypes.ForceInitialize();
            rpstVehicleUnitTimeTypes.PopulateColumns();
            //rpstWorker2.GetDataSourceValue();
            rpstVehicleUnitTimeTypes.Properties.Columns["Id"].Visible = false;
            //rpstWorker2.Properties.Columns["Self"].Visible = false;
            rpstVehicleUnitTimeTypes.ShowHeader = false;
        }

        private void RPSTWorkerUnitTimeTypes()
        {
            List<DropDownModel> unitTimes = this.GetUnitTimes();
            rpstUnitTimeTypes.DataSource = unitTimes;
            rpstUnitTimeTypes.DisplayMember = "Text";
            rpstUnitTimeTypes.ValueMember = "Id";
            rpstUnitTimeTypes.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            rpstUnitTimeTypes.NullText = string.Empty;
            rpstUnitTimeTypes.ForceInitialize();
            rpstUnitTimeTypes.PopulateColumns();
            //rpstWorker2.GetDataSourceValue();
            rpstUnitTimeTypes.Properties.Columns["Id"].Visible = false;
            //rpstWorker2.Properties.Columns["Self"].Visible = false;
            rpstUnitTimeTypes.ShowHeader = false;
        }

        private void RPSTWorkers()
        {
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
                equipment.TenderId = UICurrentManager.Instance.CurrentTender.Id;
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
                    tenderMaterialListEquipment.TenderId = UICurrentManager.Instance.CurrentTender.Id;
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
                equipment.TenderId = UICurrentManager.Instance.CurrentTender.Id;
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
                    tenderMaterialListEquipment.TenderId = UICurrentManager.Instance.CurrentTender.Id;
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

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this._owner.LoadTenderMaterialList();
            this.Close();
        }

        private void btnCikar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewAddWorker.GetFocusedRowCellValue("Id"));
                TenderMaterialListEquipment selectedWorker = TenderMaterialListEquipmentProvider.Instance.GetItem(id);
                if (selectedWorker != null)
                {
                    selectedWorker.IsMarkedForDeletion = true;
                    TenderMaterialListEquipmentProvider.Instance.Save(selectedWorker);
                    this.LoadWorkerMateriallistGrid();
                }
            }
            else
            {

            }
        }

        private void btnAracCikar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                int id = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(gridViewAddWorker.GetFocusedRowCellValue("Id"));
                TenderMaterialListEquipment selectedVehicle = TenderMaterialListEquipmentProvider.Instance.GetItem(id);
                if (selectedVehicle != null)
                {
                    selectedVehicle.IsMarkedForDeletion = true;
                    TenderMaterialListEquipmentProvider.Instance.Save(selectedVehicle);
                    this.LoadWorkerMateriallistGrid(); 
                }
            }
            else
            {

            }
        }
    }
}