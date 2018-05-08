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
    public class JobberProvider : CustomEntityBaseProvider<Jobber, JobberProvider>
    {
        protected override Hashtable GetCommonParameters(Jobber t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Address", t.Address);
            parameters.Add("AuthorNameSurname", t.AuthorNameSurname);
            parameters.Add("CompanyName", t.CompanyName);
            parameters.Add("Email", t.Email);
            parameters.Add("GSM", t.GSM);
            parameters.Add("Score", t.Score);
            parameters.Add("Telephone", t.Telephone);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("City", t.City);
            parameters.Add("TaxOffice", t.TaxOffice);
            parameters.Add("TaxNumber", t.TaxNumber);
            return parameters;
        }
        protected override void Initialize(Jobber t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Address = dr.GetValue<string>("Address");
            t.AuthorNameSurname = dr.GetValue<string>("AuthorNameSurname");
            t.CompanyName = dr.GetValue<string>("CompanyName");
            t.Email = dr.GetValue<string>("Email");
            t.GSM = dr.GetValue<string>("GSM");
            t.Score = dr.GetValue<string>("Score");
            t.Telephone = dr.GetValue<string>("Telephone");
            t.City = dr.GetValue<string>("City");
            t.TaxOffice = dr.GetValue<string>("TaxOffice");
            t.TaxNumber = dr.GetValue<string>("TaxNumber");
            t.IsActive = dr.GetValue<bool>("IsActive");
        }
    }
}
