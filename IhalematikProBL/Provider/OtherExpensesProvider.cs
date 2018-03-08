using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class OtherExpensesProvider : CustomEntityBaseProvider<OtherExpenses, OtherExpensesProvider>
    {
        protected override Hashtable GetCommonParameters(OtherExpenses t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("Price", t.Price);
            parameters.Add("TenderId", t.TenderId);
            return parameters;
        }

        protected override void Initialize(OtherExpenses t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.TenderId = dr.GetValue<int>("TenderId");
            t.Price = dr.GetValue<double>("Price");
            t.Description = dr.GetValue<string>("Description");
        }
    }
}
