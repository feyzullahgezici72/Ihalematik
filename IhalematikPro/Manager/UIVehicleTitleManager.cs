using IhalematikPro.Model;
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
    public class UIVehicleTitleManager : SingletonBase<UIVehicleTitleManager>
    {
        public List<VehicleTitle> GetVehicleTitles()
        {
            List<VehicleTitle> items = VehicleTitleProvider.Instance.GetItems();
            //List<VehicleTitleModel> models = IhalematikModelBase.GetModels<VehicleTitleModel, VehicleTitle>(items);
            return items;
        }
    }
}
