using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class OBF : Material
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }

        public double UnitPrice { get; set; }
        public bool IsActive { get; set; }
        public string DescriptionForSupplier { get; set; }
    }
}
