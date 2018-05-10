using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    class SubSupplierMaterialList : CustomEntityBase
    {
        public int SubSupplierId { get; set; }
        private SubSupplier subsupplier { get; set; }
        public SubSupplier SubSupplier
        {
            get
            {
                if (this.subsupplier == null)
                {
                    this.subsupplier = SubSupplierProvider.Instance.GetItem(this.SubSupplierId);
                }
                return this.subsupplier;
            }
            set
            {
                this.subsupplier = value;
                this.SubSupplierId = this.supplier.Id;
            }
        }

        public int MaterialListId { get; set; }
        private OfferMaterialList materialList { get; set; }
        public OfferMaterialList MaterialList
        {
            get
            {
                if (this.materialList == null)
                {
                    this.materialList = OfferMaterialListProvider.Instance.GetItem(this.MaterialListId);
                }
                return this.materialList;
            }
            set
            {
                this.materialList = value;
                this.MaterialListId = this.materialList.Id;
            }
        }

        public int OfferId { get; set; }
        private Offer offer { get; set; }
        public Offer Offer
        {
            get
            {
                if (this.offer == null)
                {
                    this.offer = OfferProvider.Instance.GetItem(this.OfferId);
                }
                return this.offer;
            }
            set
            {
                this.offer = value;
                this.OfferId = this.offer.Id;
            }
        }

        public bool IsActive { get; set; }
        public bool IsSelected { get; set; }

        public double Price { get; set; }

        public double Risk { get; set; }
        public double KDV { get; set; }

        public double PriceWithRisk
        {
            get
            {
                if (this.CurrencyType == CurrencyTypesEnum.TL)
                {
                    return Math.Round(this.Price + (this.Price * this.Risk / 100), 2);
                }
                else
                {
                    return Math.Round(this.PriceWithRate + (this.PriceWithRate * this.Risk / 100), 2);
                }
            }
        }

        //Doviz kuru ile carpilmis hali
        public double PriceWithRate
        {
            get
            {
                switch (this.CurrencyType)
                {
                    case CurrencyTypesEnum.TL:
                        return this.Price;
                    case CurrencyTypesEnum.USD:
                        return this.Price * CurrentManager.Instance.CurrentExchangeRateUSD.UnitPrice;
                    case CurrencyTypesEnum.EUR:
                        return this.Price * CurrentManager.Instance.CurrentExchangeRateEUR.UnitPrice;
                    default:
                        return this.Price;
                }
            }
        }

        public CurrencyTypesEnum CurrencyType { get; set; }
    }
}