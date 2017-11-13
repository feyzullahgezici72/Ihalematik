using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Entity;
using System.Collections;

namespace IhalematikProBL.Provider
{
    public class TenderGroupProvider : CustomEntityBaseProvider<TenderGroup, TenderGroupProvider>
    {
        protected override Hashtable GetCommonParameters(TenderGroup t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("TenderId", t.TenderId);
            
            return parameters;
        }
        protected override void Initialize(TenderGroup t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Description = dr.GetValue<string>("Description");
            t.TenderId = dr.GetValue<int>("TenderId");
        }
    }
}
