using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Rule : CustomEntityBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
