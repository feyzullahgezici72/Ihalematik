using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

namespace IhalematikPro.Model
{
    public class VehicleTitleModel : CustomSaveableModelBase
    {
        public override string ToString()
        {
            return this.Name;
        }
        public string Name { get; set; }

        public VehicleTitleModel()
        {

        }
        public VehicleTitleModel(VehicleTitle Vehicle)
        {
            this.Name = Vehicle.Name;
            this.Id = Vehicle.Id;
        }
        public override EntityBase ToEntity()
        {
            VehicleTitle vehicle = new VehicleTitle();
            vehicle.Name = this.Name;
            return vehicle;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            VehicleTitleProvider.Instance.Save(Entity);
        }
    }
}
