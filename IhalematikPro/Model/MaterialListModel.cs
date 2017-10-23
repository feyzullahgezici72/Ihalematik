using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using System.Dynamic;
using IhalematikProUI.Model;
using IhalematikPro.Manager;

namespace IhalematikPro.Model
{
    public class MaterialListModel : CustomSaveableModelBase
    {
        public float KDVPercentage { get; set; }
        public double KDVAmount
        {
            get
            {
                if (this.pozOBF == null)
                {
                    return 0;
                }
                return Math.Round((this.KDVPercentage * this.pozOBF.UnitPrice / 100 * this.Quantity), 2);
            }
        }

        public double TotalAmount
        {
            get
            {
                if (this.pozOBF == null)
                {
                    return 0;
                }
                return Math.Round(this.pozOBF.UnitPrice * this.Quantity, 2);
            }
        }
        public bool IsPoz { get; set; }

        public int PozOBFId { get; set; }
        private Material pozOBF { get; set; }
        public Material PozOBF
        {
            get
            {
                if (this.pozOBF == null)
                {
                    if (this.IsPoz)
                    {
                        Poz poz = PozProvider.Instance.GetItem(this.PozOBFId);
                        this.pozOBF = new Material().CreateMaterial(poz);
                    }

                    else
                    {
                        OBF obf = OBFProvider.Instance.GetItem(this.PozOBFId);
                        this.pozOBF = new Material().CreateMaterial(obf);
                    }

                }
                return this.pozOBF;
            }
        }

        public string PozOBFDescription
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.Description;
                }
                return string.Empty;
            }
        }

        public string PozOBFNumber
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.Number;
                }
                return string.Empty;
            }
        }

        public string PozOBFUnit
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.Unit;
                }
                return string.Empty;
            }
        }

        public double PozOBFUnitPrice
        {
            get
            {
                if (this.PozOBF != null)
                {
                    return this.PozOBF.UnitPrice;
                }
                return 0;
            }
        }

        public float Quantity { get; set; }

        public bool IsWorkship { get; set; }
        public double Markup { get; set; }

        //Birim Kar
        public double UnitMarkup
        {
            get
            {
                return Math.Round(this.Markup * this.PozOBF.UnitPrice / 100, 2);
            }
        }

        //Toplam Kar
        public double TotalMarkup
        {
            get
            {
                return Math.Round(this.UnitMarkup * this.Quantity, 2);
            }
        }

        //Calisan kar
        public double WorkerMarkup { get; set; }

        public double MaterialMarkup { get; set; }

        // Birim kar
        public double MarkupUnitPrice
        {
            get
            {
                return Math.Round(this.PozOBF.UnitPrice + this.UnitMarkup, 2);
            }
        }

        //ISCILIK(MALZEME) BIRIM FIYAT
        private double workerUnitPrice = 0;
        public double WorkerUnitPrice
        {
            get
            {
                if (this.UnitTimeType != null)
                {
                    this.workerUnitPrice = 0;
                    if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Minute)
                    {
                        foreach (TenderEquipment item in this.TenderEquipments)
                        {
                            if (item.IsWorker)
                            {
                                this.workerUnitPrice += Math.Round((item.Worker.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                            else
                            {
                                this.workerUnitPrice += Math.Round((item.Vehicle.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                        }
                    }
                    else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Hour)
                    {
                        foreach (TenderEquipment item in this.TenderEquipments)
                        {
                            if (item.IsWorker)
                            {
                                this.workerUnitPrice += Math.Round((item.Worker.TotalFare.Amount / (30 * 8)), 2) * this.UnitTime * item.Quantity;
                            }
                            else
                            {
                                this.workerUnitPrice += Math.Round((item.Vehicle.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                        }
                    }
                    else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Day)
                    {
                        foreach (TenderEquipment item in this.TenderEquipments)
                        {
                            if (item.IsWorker)
                            {
                                this.workerUnitPrice += Math.Round((item.Worker.TotalFare.Amount / 30), 2) * this.UnitTime * item.Quantity;
                            }
                            else
                            {
                                this.workerUnitPrice += Math.Round((item.Vehicle.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                        }
                    }
                    else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Week)
                    {
                        foreach (TenderEquipment item in this.TenderEquipments)
                        {
                            if (item.IsWorker)
                            {
                                this.workerUnitPrice += Math.Round((item.Worker.TotalFare.Amount / 4), 2) * this.UnitTime * item.Quantity;
                            }
                            else
                            {
                                this.workerUnitPrice += Math.Round((item.Vehicle.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                        }
                    }
                    else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Month)
                    {
                        foreach (TenderEquipment item in this.TenderEquipments)
                        {
                            if (item.IsWorker)
                            {
                                this.workerUnitPrice += Math.Round((item.Worker.TotalFare.Amount), 2) * this.UnitTime * item.Quantity;
                            }
                            else
                            {
                                this.workerUnitPrice += Math.Round((item.Vehicle.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                        }
                    }
                    else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Year)
                    {
                        foreach (TenderEquipment item in this.TenderEquipments)
                        {
                            if (item.IsWorker)
                            {
                                this.workerUnitPrice += Math.Round((item.Worker.TotalFare.Amount), 2) * 12 * this.UnitTime * item.Quantity;
                            }
                            else
                            {
                                this.workerUnitPrice += Math.Round((item.Vehicle.TotalFare.Amount / (30 * 8 * 60)), 2) * this.UnitTime * item.Quantity;
                            }
                        }
                    }
                }

                return this.workerUnitPrice;

            }
        }

        private List<TenderEquipment> tenderEquipments = null;

        public List<TenderEquipment> TenderEquipments
        {
            get
            {
                if (this.tenderEquipments == null)
                {
                    this.tenderEquipments = TenderEquipmentProvider.Instance.GetItems("TenderId", CurrentManager.CurrentTender.Id);
                }
                return this.tenderEquipments;
            }
            set
            {
                this.tenderEquipments = value;
            }
        }

        private List<TenderMaterialListEquipment> tenderMaterialListEquipment = null;

        public List<TenderMaterialListEquipment> TenderMaterialListEquipment
        {
            get
            {
                if (this.tenderMaterialListEquipment == null)
                {
                    this.tenderMaterialListEquipment = TenderMaterialListEquipmentProvider.Instance.GetItems("TenderId", CurrentManager.CurrentTender.Id);
                }
                return this.tenderMaterialListEquipment;
            }
            set
            {
                this.tenderMaterialListEquipment = value;
            }
        }


        //Zaman Tipi
        public UnitTimeTypesModel UnitTimeType { get; set; }

        //BIRIM SURE
        public int UnitTime { get; set; }

        public int TenderId { get; set; }
        private Tender tender { get; set; }
        public Tender Tender
        {
            get
            {
                if (this.tender == null)
                {
                    if (this.TenderId != 0)
                    {
                        this.tender = TenderProvider.Instance.GetItem(this.TenderId);
                    }
                }
                return this.tender;
            }
        }

        public MaterialListModel()
        {

        }
        public MaterialListModel(MaterialList Entity)
        {
            this.IsWorkship = Entity.IsWorkship;
            this.KDVPercentage = Entity.KDVPercentage;
            this.PozOBFId = Entity.PozOBFId;
            this.Quantity = Entity.Quantity;
            this.Id = Entity.Id;
            this.IsPoz = Entity.IsPoz;
            this.Markup = Entity.Markup;
            this.TenderId = Entity.TenderId;
        }

        public override EntityBase ToEntity()
        {
            MaterialList materialList = new MaterialList();
            materialList.Id = this.Id.Value;
            materialList.IsPoz = this.IsPoz;
            materialList.IsWorkship = this.IsWorkship;
            materialList.KDVPercentage = this.KDVPercentage;
            materialList.Markup = this.Markup;
            materialList.PozOBFId = this.PozOBFId;
            materialList.Quantity = this.Quantity;
            materialList.TenderId = this.TenderId;
            return materialList;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            MaterialListProvider.Instance.Save(Entity);
        }
    }
}
