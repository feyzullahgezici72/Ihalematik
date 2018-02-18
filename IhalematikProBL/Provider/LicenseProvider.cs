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
    public class LicenseProvider : CustomEntityBaseProvider<License, LicenseProvider>
    {

        public LicenseProvider()
        {
            this.EnableCaching = false;
        }
        protected override Hashtable GetCommonParameters(License t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("AuthorNameSurname", t.AuthorNameSurname);
            parameters.Add("CompanyName", t.CompanyName);
            parameters.Add("HashSerialNumber", t.HashSerialNumber);
            return parameters;
        }

        protected override void Initialize(License t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.HashSerialNumber = dr.GetValue<string>("HashSerialNumber");
            t.AuthorNameSurname = dr.GetValue<string>("AuthorNameSurname");
            t.CompanyName = dr.GetValue<string>("CompanyName");
        }
    }
}
