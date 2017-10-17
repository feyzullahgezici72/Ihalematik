using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Material : CustomEntityBase
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }

        public double UnitPrice { get; set; }
        
        public Material CreateMaterial(EntityBase Entity)
        {
            Material material = new Material();
            if (Entity is Poz)
            {
                Poz item = Entity as Poz;
                material.Number = item.Number;
                material.Unit = item.Unit;
                material.UnitPrice = item.UnitPrice;
                material.Description = item.Description;
                material.Id = item.Id;
            }
            else if (Entity is OBF)
            {

                OBF item = Entity as OBF;
                material.Number = item.Number;
                material.Unit = item.Unit;
                material.UnitPrice = item.UnitPrice;
                material.Description = item.Description;
                material.Id = item.Id;
            }

            return material;
        }
    }
}
