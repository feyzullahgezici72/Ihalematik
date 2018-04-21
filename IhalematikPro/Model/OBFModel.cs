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
        public double OfferPrice { get; internal set; }
        public string DescriptionForSupplier { get; internal set; }
        public string StokNumber { get; set; }
        public int ParentId { get; set; }
        public List<OBFModel> Childrens { get; set; }
        public double LastUnitPrice { get; set; }

        public DateTime InserTime { get; set; }

        public OBFModel(OBF Entity)
        {
            this.Number = Entity.Number;
            this.Unit = Entity.Unit;
            this.UnitPrice = Entity.UnitPrice;
            this.Description = Entity.Description;
            this.Id = Entity.Id;
            this.IsActive = Entity.IsActive;
            this.StokNumber = Entity.StokNumber;
            this.DescriptionForSupplier = Entity.DescriptionForSupplier;
            this.ParentId = Entity.ParentId;
            this.Childrens = CustomSaveableModelBase.GetModels<OBFModel, OBF>(Entity.Childrens);
            this.InserTime = Entity.InsertTime;
            //if (this.Childrens.Count != 0)
            //{
            //    this.UnitPrice = this.Childrens.OrderByDescending(p => p.InserTime).FirstOrDefault().UnitPrice;
            //}
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
            OBF.StokNumber = this.StokNumber;
            OBF.IsActive = this.IsActive;
            OBF.DescriptionForSupplier = this.DescriptionForSupplier;
            OBF.ParentId = this.ParentId;
            return OBF;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            OBFProvider.Instance.Save(Entity);
        }
    }
}
