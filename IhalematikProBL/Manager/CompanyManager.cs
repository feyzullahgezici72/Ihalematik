using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    public class CompanyManager : SingletonBase<CompanyManager>
    {
        public Company CurrentCompany
        {
            get
            {
                Company company = CompanyProvider.Instance.GetItems().FirstOrDefault();
                return company;
            }
        }
    }
}
