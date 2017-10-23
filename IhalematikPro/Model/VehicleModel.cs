using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;
using IhalematikProBL.Enum;

namespace IhalematikPro.Model
{
    public class VehicleModel : CustomSaveableModelBase
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

        public VehicleModel()
        {

        }

        public VehicleModel(Vehicle Vehicle)
        {
            this.Id = Vehicle.Id;
            this.IsCompanyVehicle = Vehicle.IsCompanyVehicle;
            this.TitleId = Vehicle.TitleId;
            this.FuelOilFare = Vehicle.FuelOilFare;
            this.FuelOilDay = Vehicle.FuelOilDay;
            this.DriverFare = Vehicle.DriverFare;
            this.MaintenanceFare = Vehicle.MaintenanceFare;
            this.ServiceFare = Vehicle.ServiceFare;
            this.GeneralFare = Vehicle.GeneralFare;
            this.OtherFare = Vehicle.OtherFare;
        }
        public override EntityBase ToEntity()
        {
            Vehicle vehicle = new Vehicle();

            if (this.Id.HasValue)
            {
                vehicle.Id = this.Id.Value;
            }
            vehicle.IsCompanyVehicle = this.IsCompanyVehicle;
            vehicle.TitleId = this.TitleId;
            vehicle.FuelOilFare = this.FuelOilFare;
            vehicle.FuelOilDay = this.FuelOilDay;
            vehicle.DriverFare = this.DriverFare;
            vehicle.MaintenanceFare = this.MaintenanceFare;
            vehicle.ServiceFare = this.ServiceFare;
            vehicle.GeneralFare = this.GeneralFare;
            vehicle.OtherFare = this.OtherFare;

            return vehicle;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            VehicleProvider.Instance.Save(Entity);
        }
    }
}
