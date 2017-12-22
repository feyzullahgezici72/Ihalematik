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

        private double monthPrice = 0;
        public double MonthPrice
        {
            get
            {
                if (this.monthPrice == 0)
                {
                    if (this.IsCompanyVehicle)
                    {

                        this.monthPrice = Math.Round(((this.FuelOilDay * this.FuelOilFare * 30) + (this.DriverFare * 30) + this.GeneralFare + this.MaintenanceFare + this.OtherFare + this.ServiceFare), 2);
                    }
                    else
                    {

                        if (this.RentType == RentTypesEnum.Day)
                        {
                            this.monthPrice = Math.Round(((this.FuelOilDay * this.FuelOilFare) + this.RentFare + this.DriverFare + this.GeneralFare + this.OtherFare) * 30, 2);
                        }
                        else if (this.RentType == RentTypesEnum.Hour)
                        {
                            this.monthPrice = Math.Round(((this.FuelOilDay * this.FuelOilFare / 8) + this.RentFare + this.DriverFare + this.GeneralFare + this.OtherFare) * 30 * 8, 2);
                        }
                        else if (this.RentType == RentTypesEnum.Month)
                        {
                            this.monthPrice = Math.Round(((this.FuelOilDay * this.FuelOilFare * 30) + this.RentFare + (this.DriverFare * 30) + this.GeneralFare + this.OtherFare), 2);
                        }
                    }
                }

                return this.monthPrice;
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
