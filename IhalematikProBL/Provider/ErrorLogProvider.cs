using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;
using SimpleApplicationBase.BL.Logging;

namespace IhalematikProBL.Provider
{
    public class ErrorLogProvider : CustomEntityBaseProvider<ErrorLog, ErrorLogProvider>
    {
        protected override Hashtable GetCommonParameters(ErrorLog t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("LogType", t.LogType);
            parameters.Add("Message", t.Message);
            return parameters;
        }

        protected override void Initialize(ErrorLog t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Message = dr.GetValue<string>("Message");
            t.LogType = dr.GetValue<ErrorLogTypesEnum>("LogType");
        }
    }
}
