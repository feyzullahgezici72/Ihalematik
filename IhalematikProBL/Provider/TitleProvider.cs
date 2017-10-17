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
    public class TitleProvider : CustomEntityBaseProvider<Title, TitleProvider>
    {
        protected override Hashtable GetCommonParameters(Title t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Name", t.Name);
            return parameters;
        }

        protected override void Initialize(Title t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Name = dr.GetValue<string>("Name");
        }
    }
}
