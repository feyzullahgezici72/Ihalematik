using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikPro.Manager;
using IhalematikProBL.Provider;

namespace IhalematikPro.Model
{
    public class OBFModel : CustomSaveableModelBase
    {

        public string Number { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }
        public bool IsActive { get; set; }

        public OBFModel(OBF Entity)
        {
            this.Number = Entity.Number;
            this.Unit = Entity.Unit;
            this.UnitPrice = Entity.UnitPrice;
            this.Description = Entity.Description;
            this.Id = Entity.Id;
            this.IsActive = Entity.IsActive;
        }

        public OBFModel()
        {

        }

        public override EntityBase ToEntity()
        {
            OBF OBF = new OBF();
            OBF.Description = this.Description;
            if (this.Id.HasValue)
            {
                OBF.Id = this.Id.Value;
            }
            OBF.Number = this.Number;
            OBF.Unit = this.Unit;
            OBF.UnitPrice = this.UnitPrice;
            OBF.IsActive = this.IsActive;
            return OBF;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            OBFProvider.Instance.Save(Entity);
        }
    }
}
