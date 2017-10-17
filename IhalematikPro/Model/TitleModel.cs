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
    public class TitleModel : CustomSaveableModelBase
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
        public TitleModel()
        {
        }

        public TitleModel(Title Entity)
        {
            this.Id = Entity.Id;
            this.Name = Entity.Name;
        }
        public override EntityBase ToEntity()
        {
            Title entity = new Title();
            entity.Name = this.Name;
            return entity;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            TitleProvider.Instance.Save(Entity);
        }
    }
}
