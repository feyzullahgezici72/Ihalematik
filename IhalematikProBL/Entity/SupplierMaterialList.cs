using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class SupplierMaterialList : CustomEntityBase
    {
        public int SupplierId { get; set; }
        private Supplier supplier { get; set; }
        public Supplier Supplier
        {
            get
            {
                if (this.supplier == null)
                {
                    this.supplier = SupplierProvider.Instance.GetItem(this.SupplierId);
                }
                return this.supplier;
            }
            set
            {
                this.supplier = value;
                this.SupplierId = this.supplier.Id;
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
                return Math.Round(this.Price + (this.Price * this.Risk / 100), 2);
            }
        }
    }
}
