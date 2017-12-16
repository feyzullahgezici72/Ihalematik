﻿using IhalematikProBL.Entity;
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

namespace IhalematikPro.Model
{
    public class MaterialListModel : CustomSaveableModelBase, ICloneable
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
                return Math.Round(this.PozOBFUnitPrice + this.UnitMarkup, 2);
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

        //ISCILIK(MALZEME) BIRIM FIYAT
        private double workerUnitPrice = 0;
        public double WorkerUnitPrice
        {
            get
            {
                if (this.UnitTimeType != null && this.TenderMaterialListEquipment != null)
                {
                    this.workerUnitPrice = 0;
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
                        if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Minute)
                        {
                            this.workerUnitPrice += Math.Round((amount / (30 * 8 * 60)), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Hour)
                        {
                            this.workerUnitPrice += Math.Round((amount / (30 * 8)), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Day)
                        {
                            this.workerUnitPrice += Math.Round((amount / (30)), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Week)
                        {
                            this.workerUnitPrice += Math.Round((amount / 4), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Month)
                        {
                            this.workerUnitPrice += Math.Round((amount), 2) * item.UnitTime * item.Quantity;
                        }
                        else if (this.UnitTimeType.UnitTimeType == IhalematikProBL.Enum.UnitTimeTypesEnum.Year)
                        {
                            this.workerUnitPrice += Math.Round(amount, 2) * 12 * item.UnitTime * item.Quantity;
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
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("TenderId", CurrentManager.Instance.CurrentTender.Id);
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
                return Math.Round(this.WorkerUnitPrice + this.MarkupUnitPrice, 2);
            }
        }

        //4. adim Toplam birim fiyat
        public double TotalFare
        {
            get
            {
                return Math.Round(this.UnitTotalFare * this.Quantity, 2);
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
            this.UnitTimeType = new UnitTimeTypesModel().Create(Entity.UnitTimeType);
            this.UnitTime = Entity.UnitTime;
            this.WorkerPercentageMarkup = Entity.WorkerMarkup;
            this.TenderMaterialListEquipment = Entity.TenderMaterialListEquipment;
            this.OfferPrice = Entity.OfferPrice;
            this.IsPoz = Entity.IsPoz;
            OfferMaterialList offerMaterialList = OfferManager.Instance.GetOfferMaterialListPrice(this.Tender.OfferId, this.PozOBFId, this.IsPoz);

            if (this.Tender.Offer != null)
            {
                this.Quantity = offerMaterialList.Quantity;
                this.PozOBFUnitPrice = offerMaterialList.Price;
                this.KDVPercentage = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<float>(offerMaterialList.OfferKDV);
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
            materialList.PozOBFId = this.PozOBFId;
            materialList.Quantity = this.Quantity;
            materialList.TenderId = this.TenderId;
            materialList.UnitTime = this.UnitTime;
            materialList.WorkerMarkup = this.WorkerPercentageMarkup;
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
