using IhalematikPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProBL.Enum;
using IhalematikProUI.Manager;

namespace IhalematikProUI.Model
{
    public class TenderMaterialListEquipmentModel : CustomSaveableModelBase
    {
        public double Quantity { get; set; }

        //BIRIM SURE
        public double UnitTime { get; set; }

        //Zaman Tipi
        public UnitTimeTypesEnum UnitTimeType { get; set; }

        public int EquipmentId { get; set; }
        private TenderEquipment equipment { get; set; }
        public TenderEquipment Equipment
        {
            get
            {
                if (this.equipment == null)
                {
                    if (this.EquipmentId != 0)
                    {
                        this.equipment = TenderEquipmentProvider.Instance.GetItem(this.EquipmentId);
                    }
                }
                return this.equipment;
            }
            set
            {
                this.equipment = value;
                if (this.equipment != null)
                {
                    this.EquipmentId = this.equipment.Id;
                }
            }
        }

        //ISCILIK(MALZEME) BIRIM FIYAT
        private double workerUnitPricea = 0;
        public double WorkerUnitPricea
        {
            get
            {
                if (this.Equipment == null)
                {
                    return 0;
                }
                this.workerUnitPricea = 0;
                double dayPerMonthValue = RuleManager.Instance.DayPerMonthValue == 0 ? 30 : RuleManager.Instance.DayPerMonthValue;
                double hourPerDayValue = RuleManager.Instance.HourPerDayValue == 0 ? 8 : RuleManager.Instance.DayPerMonthValue;

                double amount = ((Worker)this.Equipment.WorkerVehicle) == null ? 0 : ((Worker)this.Equipment.WorkerVehicle).TotalFare.Amount;
                if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Minute)
                {
                    this.workerUnitPricea += Math.Round((amount / (dayPerMonthValue * hourPerDayValue * 60)), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Hour)
                {
                    this.workerUnitPricea += Math.Round((amount / (dayPerMonthValue * hourPerDayValue)), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Day)
                {
                    this.workerUnitPricea += Math.Round((amount / (dayPerMonthValue)), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Week)
                {
                    this.workerUnitPricea += Math.Round((amount / 4), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Month)
                {
                    this.workerUnitPricea += Math.Round((amount), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Year)
                {
                    this.workerUnitPricea += Math.Round(amount, 2) * 12 * this.UnitTime * this.Quantity;
                }
                return this.workerUnitPricea;
            }
        }

        private double vehicleUnitPrice = 0;
        public double VehicleUnitPrice
        {
            get
            {
                if (this.Equipment == null)
                {
                    return 0;
                }
                this.vehicleUnitPrice = 0;
                double amount = ((Vehicle)this.Equipment.WorkerVehicle) == null ? 0 : ((Vehicle)this.Equipment.WorkerVehicle).TotalFare.Amount;
                if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Minute)
                {
                    this.vehicleUnitPrice += Math.Round((amount / (30 * 8 * 60)), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Hour)
                {
                    this.vehicleUnitPrice += Math.Round((amount / (30 * 8)), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Day)
                {
                    this.vehicleUnitPrice += Math.Round((amount / (30)), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Week)
                {
                    this.vehicleUnitPrice += Math.Round((amount / 4), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Month)
                {
                    this.vehicleUnitPrice += Math.Round((amount), 2) * this.UnitTime * this.Quantity;
                }
                else if (this.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Year)
                {
                    this.vehicleUnitPrice += Math.Round(amount, 2) * 12 * this.UnitTime * this.Quantity;
                }
                return this.vehicleUnitPrice;
            }
        }

        public int SelectedWorker { get; set; }
        public int SelectedVehicle { get; set; }
        public int SelectedUnitTimeType { get; set; }

        public TenderMaterialListEquipmentModel(TenderMaterialListEquipment Entity)
        {
            this.Equipment = Entity.Equipment;
            this.Quantity = Entity.Quantity;
            this.Id = Entity.Id;
            this.UnitTime = Entity.UnitTime;
            this.UnitTimeType = Entity.UnitTimeType;
            this.SelectedUnitTimeType = (int)this.UnitTimeType;
            if (this.Equipment.WorkerVehicle != null)
            {
                if (this.Equipment.IsWorker)
                {
                    this.SelectedWorker = this.Equipment.WorkerVehicle.Id;
                }
                else
                {
                    this.SelectedVehicle = this.Equipment.WorkerVehicle.Id;
                }
            }
        }

        public TenderMaterialListEquipmentModel()
        {

        }

        public override EntityBase ToEntity()
        {
            TenderMaterialListEquipment entity = new TenderMaterialListEquipment();

            entity.EquipmentId = this.EquipmentId;
            entity.Quantity = this.Quantity;
            entity.UnitTimeType = this.UnitTimeType;
            entity.UnitTime = this.UnitTime;
            if (this.Id.HasValue)
            {
                entity.Id = this.Id.Value;
            }
            return entity;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            TenderMaterialListEquipmentProvider.Instance.Save(Entity);
        }
    }
}
