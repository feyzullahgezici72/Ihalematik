using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Supplier : CustomEntityBase
    {
        public List<SupplierSegment> segments { get; set; }
        public List<SupplierSegment> Segments
        {
            get
            {
                if (this.segments == null)
                {
                    this.segments = SupplierSegmentProvider.Instance.GetItems();
                }
                return this.segments;
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
    }
}
