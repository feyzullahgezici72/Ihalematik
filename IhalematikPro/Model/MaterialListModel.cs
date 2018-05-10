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
using System.Collections;
using IhalematikProBL.Manager;
using IhalematikProUI.Manager;
using IhalematikProBL.Enum;

namespace IhalematikPro.Model
{
    public class MaterialListModel : CustomSaveableModelBase, ICloneable
    {
        public float KDVPercentage { get; set; }
        public double KDVAmount
        {
            get
            {
                if (this.PozOBF == null)
                {
                    return 0;
                }
                return Math.Round((this.KDVPercentage * this.PozOBFUnitPrice / 100 * this.Quantity), 2);
            }
        }

        //Malzeme Toplam Fiyat
        public double TotalAmount
        {
            get
            {
                return Math.Round(this.PozOBFUnitPrice * this.Quantity, 2);
            }
        }

        //karli maliyet toplami
        public double TotalAmountMarkup
        {
            get
            {
                return Math.Round(this.TotalMarkup + this.TotalAmount, 2);
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

        private double pozOBFUnitPrice { get; set; }
        public double PozOBFUnitPrice
        {
            get
            {
                if (this.Tender.Offer == null && this.PozOBF != null)
                {
                    this.pozOBFUnitPrice = this.PozOBF.UnitPrice;
                }
                return this.pozOBFUnitPrice;
            }
            set
            {
                this.pozOBFUnitPrice = value;
            }
        }

        public float Quantity { get; set; }

        public bool IsWorkship { get; set; }

        //Malzeme birim kar yuzdesi
        public double Markup { get; set; }

        public double Risk { get; set; }

        //Iscilik birim kar yuzdesi
        public double WorkerPercentageMarkup { get; set; }

        //Birim Kar
        public double UnitMarkup
        {
            get
            {
                return Math.Round(this.Markup * this.PozOBFUnitPrice / 100, 2);
            }
        }

        //Unit Risk
        public double UnitRisk
        {
            get
            {
                return Math.Round(this.Risk * this.PozOBFUnitPrice / 100, 2);
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

        public double MaterialMarkup { get; set; }


        //Karli Malzeme Birim Fiyat
        public double MarkupUnitPrice
        {
            get
            {
                return Math.Round(this.PozOBFUnitPrice + this.UnitMarkup + this.UnitRisk, 2);
            }
        }

        //Iscilikli Toplam Fiyat
        public double WorkerTotalAmount
        {
            get
            {
                return Math.Round(this.WorkerUnitPrice * this.Quantity, 2);
            }
        }
        //Iscilikli Birim Kar
        public double WorkerMarkup
        {
            get
            {
                return Math.Round(this.WorkerUnitPrice * this.WorkerPercentageMarkup / 100, 2);
            }
        }

        // Iscilikli Toplam Kar
        public double TotalWorkerMarkup
        {
            get
            {
                return Math.Round(this.WorkerMarkup * this.Quantity, 2);
            }
        }
        // Karli Iscilikli birim fiyat
        public double WorkerMarkupUnitPrice
        {
            get
            {
                return Math.Round(this.WorkerUnitPrice + this.WorkerMarkup, 2);
            }
        }

        // Karli maliyet Iscilikli birim fiyat
        public double TotalCustomWorkerMarkupUnitPrice
        {
            get
            {
                return Math.Round(this.CustomWorkerMarkupUnitPrice * this.Quantity, 2);
            }
        }
        //İşçilik kar tutarı malzeme bazlı
        public double TotalCustomWorkerMarkupPrice
        {
            get
            {
                return Math.Round(this.CustomWorkerMarkup * this.Quantity, 2);
            }
        }
        //ISCILIK(MALZEME) BIRIM FIYAT
        private double workerUnitPrice = 0;
        public double WorkerUnitPrice
        {
            get
            {
                if (this.UnitTimeType != null && this.TenderMaterialListEquipment != null)
                {
                    this.workerUnitPrice = 0;
                    double dayPerMonthValue = UIRuleManager.Instance.DayPerMonthValue == 0 ? 30 : UIRuleManager.Instance.DayPerMonthValue;
                    double hourPerDayValue = UIRuleManager.Instance.HourPerDayValue == 0 ? 8 : UIRuleManager.Instance.HourPerDayValue;

                    foreach (TenderMaterialListEquipment item in this.TenderMaterialListEquipment)
                    {
                        double amount = 0;
                        if (item.Equipment.IsWorker)
                        {
                            amount = ((Worker)item.Equipment.WorkerVehicle) == null ? 0 : ((Worker)item.Equipment.WorkerVehicle).TotalFare.Amount;
                        }
                        else
                        {
                            amount = ((Vehicle)item.Equipment.WorkerVehicle) == null ? 0 : ((Vehicle)item.Equipment.WorkerVehicle).TotalFare.Amount;
                        }
                        if (item.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Minute)
                        {
                            this.workerUnitPrice += Math.Round((amount / (dayPerMonthValue * hourPerDayValue * 60)), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (item.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Hour)
                        {
                            this.workerUnitPrice += Math.Round((amount / (dayPerMonthValue * hourPerDayValue)), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (item.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Day)
                        {
                            this.workerUnitPrice += Math.Round((amount / (dayPerMonthValue)), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (item.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Week)
                        {
                            this.workerUnitPrice += Math.Round((amount / 4), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (item.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Month)
                        {
                            this.workerUnitPrice += Math.Round((amount), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (item.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Year)
                        {
                            this.workerUnitPrice += Math.Round(amount, 2) * 12 * item.UnitTime * item.Quantity;
                        }
                    }
                }

                return this.workerUnitPrice;

            }
        }

        //Custom ISCILIK(MALZEME) BIRIM FIYAT
        public double CustomWorkerUnitPrice { get; set; }

        //Custom Iscilikli Toplam Fiyat
        public double CustomWorkerTotalAmount
        {
            get
            {
                return Math.Round(this.CustomWorkerUnitPrice * this.Quantity, 2);
            }
        }


        //Custom Karli Iscilikli birim fiyat
        public double CustomWorkerMarkupUnitPrice
        {
            get
            {
                return Math.Round(this.CustomWorkerUnitPrice + this.CustomWorkerMarkup, 2);
            }
        }

        //Custom Iscilikli Birim Kar
        public double CustomWorkerMarkup
        {
            get
            {
                return Math.Round(this.CustomWorkerUnitPrice * this.WorkerPercentageMarkup / 100, 2);
            }
        }

        private List<TenderEquipment> tenderEquipments = null;

        public List<TenderEquipment> TenderEquipments
        {
            get
            {
                if (this.tenderEquipments == null)
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("TenderId", UICurrentManager.Instance.CurrentTender.Id);
                    //parameters.Add("MaterialId", this.Id);
                    this.tenderEquipments = TenderEquipmentProvider.Instance.GetItems(parameters);
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
                //if (this.tenderMaterialListEquipment == null)
                //{
                this.tenderMaterialListEquipment = new List<IhalematikProBL.Entity.TenderMaterialListEquipment>();
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("TenderId", this.Tender.Id);
                parameters.Add("MaterialId", this.Id);

                this.tenderMaterialListEquipment = TenderMaterialListEquipmentProvider.Instance.GetItems(parameters);
                //}
                return this.tenderMaterialListEquipment;
            }
            set
            {
                this.tenderMaterialListEquipment = value;
            }
        }
        #region 4. adim
        //4. adim birim fiyat

        public double UnitTotalFare
        {
            get
            {
                if (!UICurrentManager.Instance.CurrentTender.PersonHour)
                {
                    return Math.Round(this.CustomWorkerMarkupUnitPrice + this.MarkupUnitPrice, 2);
                }
                else
                {

                    return Math.Round(this.WorkerMarkupUnitPrice + this.MarkupUnitPrice, 2);
                }
            }
        }

        public double TotalFare
        {
            get
            {
                return Math.Round(this.UnitTotalFare * this.Quantity, 2);
            }
        }

        public double UnitTotalFarePreview { get; set; }
        public double TotalFarePreview
        {
            get
            {
                return Math.Round(this.UnitTotalFarePreview * this.Quantity, 2);
            }
        }

        #endregion

        //Zaman Tipi
        public UnitTimeTypesModel UnitTimeType { get; set; }

        //BIRIM SURE
        public int UnitTime { get; set; }
        public double OfferPrice { get; set; }

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

        public JobberTypesEnum JobberType { get; set; }

        public double CarriagePercent { get; set; }
        public MaterialListModel()
        {

        }
        public MaterialListModel(MaterialList Entity)
        {
            this.IsWorkship = Entity.IsWorkship;
            this.KDVPercentage = Entity.KDVPercentage;
            this.PozOBFId = Entity.PozOBFId;
            this.Quantity = Entity.Quantity;
            this.TenderId = Entity.TenderId;
            this.Id = Entity.Id;
            this.Markup = Entity.Markup;
            this.Risk = Entity.Risk;
            this.UnitTimeType = new UnitTimeTypesModel().Create(Entity.UnitTimeType);
            this.UnitTime = Entity.UnitTime;
            this.WorkerPercentageMarkup = Entity.WorkerMarkup;
            this.TenderMaterialListEquipment = Entity.TenderMaterialListEquipment;
            this.OfferPrice = Entity.OfferPrice;
            this.IsPoz = Entity.IsPoz;
            this.CustomWorkerUnitPrice = Entity.CustomWorkerUnitPrice;
            this.CarriagePercent = Entity.CarriagePercent;
           
            if (this.Tender.Offer != null)
            {
                OfferMaterialList offerMaterialList = OfferManager.Instance.GetOfferMaterialListPrice(this.Tender.OfferId, this.PozOBFId, this.IsPoz);
                this.Quantity = offerMaterialList.Quantity;
                if (offerMaterialList.IsSelected)
                {
                    this.PozOBFUnitPrice = offerMaterialList.Price;
                    this.KDVPercentage = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(offerMaterialList.OfferKDV);
                }
                else
                {
                    this.PozOBFUnitPrice = Entity.PozOBF.UnitPrice;
                    this.KDVPercentage = 18;
                }
            }
            //this.TenderMaterialListEquipment = IhalematikModelBase.GetModels<TenderMaterialListEquipmentModel, TenderMaterialListEquipment>(Entity.TenderMaterialListEquipment);
        }

        public override EntityBase ToEntity()
        {
            MaterialList materialList = new MaterialList();
            materialList.Id = this.Id.Value;
            materialList.IsPoz = this.IsPoz;
            materialList.IsWorkship = this.IsWorkship;
            materialList.KDVPercentage = this.KDVPercentage;
            materialList.Markup = this.Markup;
            materialList.Risk = this.Risk;
            materialList.PozOBFId = this.PozOBFId;
            materialList.Quantity = this.Quantity;
            materialList.TenderId = this.TenderId;
            materialList.UnitTime = this.UnitTime;
            materialList.WorkerMarkup = this.WorkerPercentageMarkup;
            materialList.CarriagePercent = this.CarriagePercent;

            if (this.UnitTimeType != null)
            {
                materialList.UnitTimeType = this.UnitTimeType.UnitTimeType;
            }
            return materialList;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            MaterialListProvider.Instance.Save(Entity);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
