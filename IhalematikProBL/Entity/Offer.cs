﻿using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Offer : CustomEntityBase
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public DateTime DateTime { get; set; }

        private List<OfferMaterialList> materialList { get; set; }
        public List<OfferMaterialList> MaterialList
        {
            get
            {
                if (this.materialList == null)
                {
                    this.materialList = OfferMaterialListProvider.Instance.GetItems("OfferId", this.Id);
                }

                return this.materialList;
            }
            set
            {
                this.materialList = value;
            }
        }

        private List<Supplier> suppliers = new List<Supplier>();
        public List<Supplier> Suppliers
        {
            get
            {
                List<SupplierMaterialList> items = SupplierMaterialListProvider.Instance.GetItems("OfferId", this.Id);
                if (items.Count != 0)
                {
                    this.suppliers.AddRange(items.GroupBy(p => p.SupplierId).Select(p => p.FirstOrDefault().Supplier));
                }
                return this.suppliers;
            }
        }

    }
}
