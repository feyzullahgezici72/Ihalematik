using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Manager
{
    public class UIMaterialListManager : SingletonBase<UIMaterialListManager>
    {
        
        public List<MaterialList> GetMaterialListNonWorkship()
        {

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("IsWorkship", false);
            parameters.Add("TenderId", UICurrentManager.Instance.CurrentTender.Id);
            List<MaterialList> items = MaterialListProvider.Instance.GetItems(parameters);
            return items;
        }
        public List<MaterialList> GetMaterialListIsWorkship()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("IsWorkship", true);
            parameters.Add("TenderId", UICurrentManager.Instance.CurrentTender.Id);
            List<MaterialList> items = MaterialListProvider.Instance.GetItems(parameters);
            return items;
        }

        public List<MaterialList> GetMaterialLists()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("TenderId", UICurrentManager.Instance.CurrentTender.Id);
            List<MaterialList> items = MaterialListProvider.Instance.GetItems(parameters);
            return items;
        }
    }
}
