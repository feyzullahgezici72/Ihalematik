using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Jobber : CustomEntityBase
    {
        public string CompanyName { get; set; }
        public string AuthorNameSurname { get; set; }
        public string GSM { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Score { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string City { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }

        public bool IsSelected { get; set; }
    }
}
