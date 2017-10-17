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
            return parameters;
        }

        protected override void Initialize(Tender t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Number = dr.GetValue<int>("Number");
            t.Description = dr.GetValue<string>("Description");
            t.LastOfferDate = dr.GetValue<DateTime?>("LastOfferDate");
            t.IsActive = dr.GetValue<bool>("IsActive");
        }

        public override OperationResult Save(Tender t)
        {
            return base.Save(t);
        }
    }
}
