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
    public class TenderManager : SingletonBase<TenderManager>
    {
        public int GetLastTenderNumber()
        {
            object tenderNumber = CustomDBConnectionManager.Instance.ExecuteScalar("Tender_GetLastNumber", new System.Collections.Hashtable());
            return (int)tenderNumber;
        }

        public bool Save(Tender Tender)
        {
            OperationResult result = TenderProvider.Instance.Save(Tender);

            if (result.Success)
            {
                foreach (TenderEquipment item in Tender.Equipments)
                {
                    item.TenderId = Tender.Id;
                    TenderEquipmentProvider.Instance.Save(item);
                }
            }
            return result.Success;
        }
    }
}
