using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class OtherExpenses : CustomEntityBase
    {
        public string Description { get; set; }
        public int TenderId { get; set; }
        public double Price { get; set; }
        public OtherExpenses()
        {

        }

        public OtherExpenses(int TenderId)
        {
            this.TenderId = TenderId;
        }
    }
}
