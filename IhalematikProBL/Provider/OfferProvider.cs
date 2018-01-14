using IhalematikProBL.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class OfferProvider : CustomEntityBaseProvider<Offer, OfferProvider>
    {
        protected override Hashtable GetCommonParameters(Offer t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("Number", t.Number);
            parameters.Add("IsActive", t.IsActive);
            if (t.DateTime == DateTime.MinValue)
            {
                parameters.Add("DateTime", DateTime.Now.AddDays(200));
            }
            else
            {
                parameters.Add("DateTime", t.DateTime);
            }
            parameters.Add("IsCompleated", t.IsCompleated);
            return parameters;
        }

        protected override void Initialize(Offer t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Description = dr.GetValue<string>("Description");
            t.Number = dr.GetValue<string>("Number");
            t.DateTime = dr.GetValue<DateTime>("DateTime");
            t.IsActive = dr.GetValue<bool>("IsActive");
            t.IsCompleated = dr.GetValue<bool>("IsCompleated");
        }
    }
}
