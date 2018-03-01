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
    public class MemberProvider : CustomEntityBaseProvider<Member, MemberProvider>
    {
        protected override Hashtable GetCommonParameters(Member t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Password", t.Password);
            parameters.Add("UserName", t.UserName);
            return parameters;
        }

        protected override void Initialize(Member t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.UserName = dr.GetValue<string>("UserName");
            t.Password = dr.GetValue<string>("Password");
        }
    }
}
