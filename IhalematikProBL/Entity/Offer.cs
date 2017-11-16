using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Offer : CustomEntityBase
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
