using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Entity
{
    public class Vehicle : CustomEntityBase
    {
        public int TitleId { get; set; }
        private VehicleTitle title { get; set; }
        public VehicleTitle Title
        {
            get
            {
                if (this.title == null)
                {
                    if (TitleId != 0)
                    {
                        this.title = VehicleTitleProvider.Instance.GetItem(this.TitleId);
                    }
                }

                return this.title;
            }
        }

        //sirket aracimi?
        public bool IsCompanyVehicle { get; set; }

        public Fare TotalFare
        {
            get
            {
                return new Fare(IhalematikProBL.Enum.CurrencyTypesEnum.TL, this.MonthPrice);
            }
        }

        public double HourPrice
        {
            get
            {
                return Math.Round(this.DayPrice / 8);
            }
        }
        public double DayPrice
        {
            get
            {
                //return 0;
                return Math.Round(this.MonthPrice / 30);
            }
        }

        public double MonthPrice
        {
            get
            {
                return Math.Round(this.DriverFare + (this.FuelOilDay * this.FuelOilFare * 30) + this.GeneralFare + this.MaintenanceFare + this.OtherFare + this.ServiceFare);
            }
        }

        //Gunluk yakit(LT)
        public float FuelOilDay { get; set; }

        //Yakit litre fiyati(LT)
        public double FuelOilFare { get; set; }

        //Sofor yevmiyesi
        public double DriverFare { get; set; }

        //Bakim Gideri
        public double MaintenanceFare { get; set; }

        //Bakim Gideri
        public double ServiceFare { get; set; }

        //Bakim Gideri
        public double GeneralFare { get; set; }

        //Bakim Gideri
        public double OtherFare { get; set; }
        public RentTypesEnum RentType { get; set; }
        public double RentFare { get; set; }

        public bool IsActive { get; set; }
    }
}
