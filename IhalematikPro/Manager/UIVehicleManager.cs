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
    public class UIVehicleManager : SingletonBase<UIVehicleManager>
    {
        public List<VehicleModel> GetVehicles()
        {
            List<Vehicle> items = VehicleProvider.Instance.GetItems();
            List<VehicleModel> models = IhalematikModelBase.GetModels<VehicleModel, Vehicle>(items);
            return models;
        }
    }
}
