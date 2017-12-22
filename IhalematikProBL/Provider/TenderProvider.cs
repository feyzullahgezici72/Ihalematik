using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;
using SimpleApplicationBase.BL.Base;

namespace IhalematikProBL.Provider
{
    public class TenderProvider : CustomEntityBaseProvider<Tender, TenderProvider>
    {
        protected override Hashtable GetCommonParameters(Tender t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("Number", t.Number);
            parameters.Add("LastOfferDate", t.LastOfferDate);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("CompanyName", t.CompanyName);
            parameters.Add("EkapNumber", t.EkapNumber);
            parameters.Add("Type", t.Type);
            parameters.Add("Scope", t.Scope);
            parameters.Add("Procedure", t.Procedure);
            parameters.Add("Place", t.Place);
            parameters.Add("Management", t.Management);
            parameters.Add("OfferId", t.OfferId);
            parameters.Add("NearlyTotalAmount", t.NearlyTotalAmount);
            return parameters;
        }

        protected override void Initialize(Tender t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Number = dr.GetValue<int>("Number");
            t.Description = dr.GetValue<string>("Description");
            t.LastOfferDate = dr.GetValue<DateTime?>("LastOfferDate");
            t.IsActive = dr.GetValue<bool>("IsActive");
            t.CompanyName = dr.GetValue<string>("CompanyName");
            t.EkapNumber = dr.GetValue<string>("EkapNumber");
            t.Type = dr.GetValue<string>("Type");
            t.Scope = dr.GetValue<string>("Scope");
            t.Procedure = dr.GetValue<string>("Procedure");
            t.Place = dr.GetValue<string>("Place");
            t.Management = dr.GetValue<string>("Management");
            t.OfferId = dr.GetValue<int>("OfferId");
            t.NearlyTotalAmount = dr.GetValue<double>("NearlyTotalAmount");
        }
    }
}
