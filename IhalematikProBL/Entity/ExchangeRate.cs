using IhalematikProBL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class ExchangeRate : CustomEntityBase
    {
        public double UnitPrice { get; set; }

        public CurrencyTypesEnum CurrencyType { get; set; }
    }
}
