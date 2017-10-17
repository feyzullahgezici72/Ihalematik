using IhalematikProBL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Fare : CustomEntityBase
    {
        public CurrencyTypesEnum CurrencyType { get; set; }

        //Ucret parasi orn: 100 TL
        public double Amount { get; set; }

        public Fare(CurrencyTypesEnum CurrencyType, double Amount)
        {
            this.CurrencyType = CurrencyType;
            this.Amount = Amount;
        }
        public Fare(double Amount)
        {
            this.CurrencyType = CurrencyTypesEnum.TL; //TODO feyzullahg rule tablosuna alinacak
            this.Amount = Amount;
        }

        public string DisplayAmount
        {
            get
            {
                return string.Format("{0} {1}", this.Amount, this.CurrencyType.ToString());
            }
        }
    }
}
