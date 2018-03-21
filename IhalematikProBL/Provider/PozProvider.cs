using IhalematikProBL.Entity;
using System.Collections.Generic;
using System.Collections;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class PozProvider : CustomEntityBaseProvider<Poz, PozProvider>
    {
        public PozProvider()
        {
            this.EnableCaching = false;
        }
        protected override Hashtable GetCommonParameters(Poz t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("Number", t.Number);
            parameters.Add("Unit", t.Unit);
            parameters.Add("UnitPrice", t.UnitPrice);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("DescriptionForSupplier", t.DescriptionForSupplier);
            parameters.Add("Year", t.Year);
            return parameters;
        }

        protected override void Initialize(Poz t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Description = dr.GetValue<string>("Description");
            t.Number = dr.GetValue<string>("Number");
            t.Unit = dr.GetValue<string>("Unit");
            t.UnitPrice = dr.GetValue<double>("UnitPrice");
            t.IsActive = dr.GetValue<bool>("IsActive");
            t.Year = dr.GetValue<int>("Year");
            t.DescriptionForSupplier = dr.GetValue<string>("DescriptionForSupplier");
        }
    }
}
