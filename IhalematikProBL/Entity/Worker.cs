using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Worker : CustomEntityBase
    {
        public string Code { get; set; }

        public int TitleId { get; set; }
        private Title title { get; set; }
        public Title Title
        {
            get
            {
                if (this.TitleId != 0)
                {
                    this.title = TitleProvider.Instance.GetItem(this.TitleId); // todo feyzullahg provider
                }

                return this.title;
            }
            set
            {
                this.title = value;
                if (this.title != null)
                {
                    this.TitleId = this.title.Id;
                }
            }
        }

        public bool IsNormal { get; set; }

        //Net Maas
        public Fare BaseFare { get; set; }

        public Fare SGKPrimFare { get; set; }

        public Fare AGIFare { get; set; }

        public Fare StopajFare { get; set; }

        //Damga Vergisi
        public Fare StampTaxFare { get; set; }

        //Yemek ucreti
        public Fare FoodFare { get; set; }

        //Yol ucreti
        public Fare TravelFare { get; set; }

        //Konaklama ucreti
        public Fare HotelFare { get; set; }

        public Fare ISGFare { get; set; }

        //Diger ucretler
        public Fare ExtraFare { get; set; }
    }
}
