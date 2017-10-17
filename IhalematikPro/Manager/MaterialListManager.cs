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
    public class MaterialListManager : SingletonBase<MaterialListManager>
    {
        public List<MaterialList> GetMaterialListIsWorkship()
        {
            List<MaterialList> items = MaterialListProvider.Instance.GetItems("IsWorkship", true);
            return items;
        }
        public List<MaterialList> GetMaterialListNonWorkship()
        {
            List<MaterialList> items = MaterialListProvider.Instance.GetItems("IsWorkship", false);
            return items;
        }
    }
}
