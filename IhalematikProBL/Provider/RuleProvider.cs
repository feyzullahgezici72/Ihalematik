using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;
using System.Collections;

namespace IhalematikProBL.Provider
{
    public class RuleProvider : CustomEntityBaseProvider<Rule, RuleProvider>
    {
        protected override Hashtable GetCommonParameters(Rule t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Name", t.Name);
            parameters.Add("Code", t.Code);
            parameters.Add("Value", t.Value);

            return parameters;
        }
        protected override void Initialize(Rule t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Code = dr.GetValue<string>("Code");
            t.Name = dr.GetValue<string>("Name");
            t.Value = dr.GetValue<string>("Value");
        }
    }
}
