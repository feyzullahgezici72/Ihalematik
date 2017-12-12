using IhalematikProBL.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Manager;

namespace IhalematikProBL.Provider
{
    public class SupplierMaterialListProvider : CustomEntityBaseProvider<SupplierMaterialList, SupplierMaterialListProvider>
    {
        protected override Hashtable GetCommonParameters(SupplierMaterialList t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("MaterialListId", t.MaterialListId);
            parameters.Add("OfferId", t.OfferId);
            parameters.Add("SupplierId", t.SupplierId);
            parameters.Add("Price", t.Price);
            parameters.Add("Risk", t.Risk);
            parameters.Add("IsSelected", t.IsSelected);
            parameters.Add("KDV", t.KDV);
            return parameters;
        }

        protected override void Initialize(SupplierMaterialList t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.SupplierId = dr.GetValue<int>("SupplierId");
            t.OfferId = dr.GetValue<int>("OfferId");
            t.MaterialListId = dr.GetValue<int>("MaterialListId");
            t.Price = dr.GetValue<double>("Price");
            t.Risk = dr.GetValue<double>("Risk");
            t.IsActive = dr.GetValue<bool>("IsActive");
            t.IsSelected = dr.GetValue<bool>("IsSelected");
            t.KDV = dr.GetValue<double>("KDV");
        }

        public void SupplierMaterialListSelectedUpdate(int OfferId)
        {
            Hashtable param = new Hashtable();
            param.Add("OfferId", OfferId);
            CustomDBConnectionManager.Instance.ExecuteNonQuery("SupplierMaterialListSelectedUpdate", param);
        }
    }
}
