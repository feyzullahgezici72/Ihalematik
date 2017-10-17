using IhalematikProBL.Entity;
using SimpleApplicationBase.Web.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikPro.Model
{
    public abstract class CustomSaveableModelBase : SaveableModelBase
    {
        public int? Id { get; set; }

        public string ReferrerActionName { get; set; }

        public CustomSaveableModelBase()
        {
        }

        //public CustomSaveableModelBase(CustomEntityBase Entity)
        //    : base(Entity)
        //{
        //    if (Entity != null)
        //    {
        //        this.Id = Entity.Id;
        //    }
        //}
    }
}
