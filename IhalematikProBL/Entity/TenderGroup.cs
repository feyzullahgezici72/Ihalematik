using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class TenderGroup : CustomEntityBase
    {
        private Tender tender { get; set; }
        public int TenderId { get; set; }
        public Tender Tender
        {
            get
            {
                if (this.tender == null)
                {
                    this.tender = TenderProvider.Instance.GetItem(this.TenderId);
                }
                return this.tender;
            }
            set
            {
                this.tender = value;
                this.TenderId = this.tender.Id;
            }
        }
        public string Description { get; set; }
    }
}
