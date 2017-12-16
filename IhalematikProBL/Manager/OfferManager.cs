using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    public class OfferManager : SingletonBase<OfferManager>
    {
        public int GetLastOfferNumber()
        {
            object offerNumber = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(CustomDBConnectionManager.Instance.ExecuteScalar("Offer_GetLastNumber", new System.Collections.Hashtable()));

            return (int)offerNumber;
        }

        public SupplierMaterialList GetOfferMaterialListPrice(int OfferMaterialListId)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("MaterialListId", OfferMaterialListId);
            param.Add("IsSelected", true);
            List<SupplierMaterialList> supplierMaterialLists = SupplierMaterialListProvider.Instance.GetItems(param);
            if (supplierMaterialLists.FirstOrDefault() == null)
            {
                return new SupplierMaterialList();
            }
            return supplierMaterialLists.FirstOrDefault();
        }

        public OfferMaterialList GetOfferMaterialListPrice(int OfferId, int PozOBFId, bool IsPoz)
        {
            OfferMaterialList result = new OfferMaterialList();
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("OfferId", OfferId);
            param.Add("PozOBFId", PozOBFId);
            param.Add("IsPoz", IsPoz);
            List<OfferMaterialList> offerMaterialLists = OfferMaterialListProvider.Instance.GetItems(param);

            if (offerMaterialLists.FirstOrDefault() != null)
            {
                result = offerMaterialLists.FirstOrDefault();
                SupplierMaterialList supplierMaterialList = this.GetOfferMaterialListPrice(offerMaterialLists.FirstOrDefault().Id);
                result.Price = supplierMaterialList.PriceWithRisk;
                result.OfferKDV = supplierMaterialList.KDV;
            }

            return result;
        }
    }
}
