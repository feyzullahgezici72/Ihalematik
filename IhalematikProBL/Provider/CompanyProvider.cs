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
    public class CompanyProvider : CustomEntityBaseProvider<Company, CompanyProvider>
    {
        protected override Hashtable GetCommonParameters(Company t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Name", t.Name);
            parameters.Add("Title", t.Title);
            parameters.Add("BossName", t.BossName);
            parameters.Add("BossSurName", t.BossSurName);
            parameters.Add("Address", t.Address);
            parameters.Add("Fax", t.Fax);
            parameters.Add("GSM", t.GSM);
            parameters.Add("Telephone1", t.Telephone1);
            parameters.Add("Telephone2", t.Telephone2);
            parameters.Add("MailAddress", t.MailAddress);
            parameters.Add("WebAddress", t.WebAddress);
            parameters.Add("MailPassword", t.MailPassword);
            parameters.Add("TaxOffice", t.TaxOffice);
            parameters.Add("TaxNumber", t.TaxNumber);
            parameters.Add("LogoPath", t.LogoPath);
            return parameters;
        }
        protected override void Initialize(Company t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Address = dr.GetValue<string>("Address");
            t.BossName = dr.GetValue<string>("BossName");
            t.BossSurName = dr.GetValue<string>("BossSurName");
            t.Fax = dr.GetValue<string>("Fax");
            t.GSM = dr.GetValue<string>("GSM");
            t.MailAddress = dr.GetValue<string>("MailAddress");
            t.Name = dr.GetValue<string>("Name");
            t.Telephone1 = dr.GetValue<string>("Telephone1");
            t.Telephone2 = dr.GetValue<string>("Telephone2");
            t.Title = dr.GetValue<string>("Title");
            t.WebAddress = dr.GetValue<string>("WebAddress");
            t.MailPassword = dr.GetValue<string>("MailPassword");
            t.TaxNumber = dr.GetValue<string>("TaxNumber");
            t.TaxOffice = dr.GetValue<string>("TaxOffice");
            t.LogoPath = dr.GetValue<string>("LogoPath");
        }

    }
}
