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

        //Issizlik sigorta fonu
        public Fare WorklesFonFare { get; set; }

        //Gelir Vergisi
        public Fare IncomeTaxFare { get; set; }

        //Kidem Tazminati
        public Fare SeveranceFare { get; set; }

        public Fare TotalFare
        {
            get
            {
                double totalAmount = this.AGIFare.Amount + this.BaseFare.Amount + this.ExtraFare.Amount + this.FoodFare.Amount + this.HotelFare.Amount + this.ISGFare.Amount + this.SGKPrimFare.Amount + this.StampTaxFare.Amount + this.TravelFare.Amount + this.WorklesFonFare.Amount + this.IncomeTaxFare.Amount + this.SeveranceFare.Amount;

                return new Fare(totalAmount);
            }
        }

        public Fare DayFare
        {
            get
            {
                return new Fare(Math.Round((this.TotalFare.Amount / 30), 2));
            }
        }

        public Fare HourFare
        {
            get
            {
                return new Fare(Math.Round((this.DayFare.Amount / 8), 2));
            }
        }

        public Fare MinuteFare
        {
            get
            {
                return new Fare(Math.Round((this.HourFare.Amount / 60), 2));
            }
        }
    }
}
