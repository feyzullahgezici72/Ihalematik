using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.BL.Base;
using IhalematikProBL.Entity;
using IhalematikProBL.Provider;

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
                return new Fare(IhalematikProBL.Enum.CurrencyTypesEnum.TL, 0);
            }
        }

        //calisacak saat
        public float WorkHour { get; set; }

        //saatlik gider
        public double HourPrice { get; set; }

        //diger giderler
        public double OtherPrice { get; set; }

        public double DayPrice
        {
            get
            {
                return Math.Round(this.HourPrice * 8, 2);
            }
        }

        public double MonthPrice
        {
            get
            {
                return Math.Round(this.DayPrice * 30, 2);
            }
        }


        public VehicleModel()
        {

        }

        public VehicleModel(Vehicle Vehicle)
        {
            this.HourPrice = Vehicle.HourPrice;
            this.Id = Vehicle.Id;
            this.IsCompanyVehicle = Vehicle.IsCompanyVehicle;
            this.OtherPrice = Vehicle.OtherPrice;
            this.TitleId = Vehicle.TitleId;
            this.WorkHour = Vehicle.WorkHour;
        }
        public override EntityBase ToEntity()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.HourPrice = this.HourPrice;
            if (this.Id.HasValue)
            {
                vehicle.Id = this.Id.Value;
            }
            vehicle.IsCompanyVehicle = this.IsCompanyVehicle;
            vehicle.OtherPrice = this.OtherPrice;
            vehicle.TitleId = this.TitleId;
            vehicle.WorkHour = this.WorkHour;

            return vehicle;
        }

        protected override void SaveEntity(EntityBase Entity)
        {
            VehicleProvider.Instance.Save(Entity);
        }
    }
}
