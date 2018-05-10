using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    class SubSupplier: CustomEntityBase
    {
        public List<SubSupplierSegment> SubSegments { get; set; }

        public string SubSupplierSegmentTexts
        {
            get
            {
                if (this.SubSegments != null)
                {
                    return string.Join(";", this.SubSegments.Select(p => p.Name));
                }
                return string.Empty;
            }
        }
        public string CompanyName { get; set; }
        public string AuthorNameSurname { get; set; }
        public string GSM { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Score { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string Country { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
    }
}
