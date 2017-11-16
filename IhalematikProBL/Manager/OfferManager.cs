using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    public class OfferManager : SingletonBase<OfferManager>
    {
        public int GetLastOfferNumber()
        {
            object offerNumber = SimpleApplicationBase.Toolkit.Helpers.GetValueFromObject<int>(CustomDBConnectionManager.Instance.ExecuteScalar("Offer_GetLastNumber", new System.Collections.Hashtable()));
           
            return (int)offerNumber;
        }
    }
}
