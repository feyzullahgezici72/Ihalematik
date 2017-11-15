using IhalematikPro.Model;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProUI.Model;
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
        public List<Vehicle> GetVehicles()
        {
            List<Vehicle> items = VehicleProvider.Instance.GetItems();
            //List<VehicleModel> models = IhalematikModelBase.GetModels<VehicleModel, Vehicle>(items);
            return items;
        }
        public List<DropDownModel> GetDropDownVehicles()
        {
            List<Vehicle> vehicles = VehicleProvider.Instance.GetItems();
            List<DropDownModel> models = new List<DropDownModel>();
            foreach (var item in vehicles)
            {
                DropDownModel model = new DropDownModel()
                {
                    Id = item.Id,
                    Text = item.Title.Name
                };
                models.Add(model);
            }
            return models;
        }
    }
}
