using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Member : CustomEntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
