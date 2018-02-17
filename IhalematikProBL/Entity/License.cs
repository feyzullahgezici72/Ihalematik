using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class License : CustomEntityBase
    {
        public string CompanyName { get; set; }
        public string AuthorNameSurname { get; set; }
        public string HashSerialNumber { get; set; }
    }
}
