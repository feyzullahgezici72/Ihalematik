using IhalematikProBL.Provider;
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

        public bool IsSelected { get; set; }

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
                if (this.suppliers.Count == 0 && items.Count != 0)
                {
                    this.suppliers.AddRange(items.GroupBy(p => p.SupplierId).Select(p => p.FirstOrDefault().Supplier));
                }
                return this.suppliers;
            }
        }

        private List<SupplierMaterialList> supplierMaterialList { get; set; }
        public List<SupplierMaterialList> SelectedSupplierMaterialList
        {
            get
            {
                if (this.supplierMaterialList == null)
                {
                    Dictionary<string, object> param = new Dictionary<string, object>();
                    param.Add("OfferId", this.Id);
                    param.Add("IsSelected", true);
                    this.supplierMaterialList = SupplierMaterialListProvider.Instance.GetItems(param);
                }

                return this.supplierMaterialList;
            }
            set
            {
                this.supplierMaterialList = value;
            }
        }
    }
}
