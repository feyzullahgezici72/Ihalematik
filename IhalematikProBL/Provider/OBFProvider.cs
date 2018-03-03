using IhalematikProBL.Entity;
using System.Collections.Generic;
using System.Collections;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class OBFProvider : CustomEntityBaseProvider<OBF, OBFProvider>
    {
        protected override Hashtable GetCommonParameters(OBF t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("Number", t.Number);
            parameters.Add("Unit", t.Unit);
            parameters.Add("UnitPrice", t.UnitPrice);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("DescriptionForSupplier", t.DescriptionForSupplier);
            parameters.Add("StokNumber", t.StokNumber);
            return parameters;
        }

        protected override void Initialize(OBF t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Description = dr.GetValue<string>("Description");
            t.Number = dr.GetValue<string>("Number");
            t.Unit = dr.GetValue<string>("Unit");
            t.UnitPrice = dr.GetValue<double>("UnitPrice");
            t.IsActive = dr.GetValue<bool>("IsActive");
            t.DescriptionForSupplier = dr.GetValue<string>("DescriptionForSupplier");
            t.StokNumber = dr.GetValue<string>("StokNumber");
        }
    }
}
