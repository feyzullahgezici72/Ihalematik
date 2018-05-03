using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Enum;

namespace IhalematikProBL.Provider
{
    public class ExchangeRateProvider : CustomEntityBaseProvider<ExchangeRate, ExchangeRateProvider>
    {
        protected override Hashtable GetCommonParameters(ExchangeRate t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("CurrencyType", t.CurrencyType);
            parameters.Add("UnitPrice", t.UnitPrice);
            return parameters;
        }

        protected override void Initialize(ExchangeRate t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.UnitPrice = dr.GetValue<double>("UnitPrice");
            t.CurrencyType = dr.GetValue<CurrencyTypesEnum>("CurrencyType");
        }
    }
}
