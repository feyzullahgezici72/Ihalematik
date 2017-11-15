using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Enum;

namespace IhalematikProBL.Provider
{
    public class VehicleProvider : CustomEntityBaseProvider<Vehicle, VehicleProvider>
    {
        public VehicleProvider()
        {
            this.EnableCaching = true;
        }
        protected override Hashtable GetCommonParameters(Vehicle t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("IsCompanyVehicle", t.IsCompanyVehicle);
            parameters.Add("TitleId", t.TitleId);
            parameters.Add("DriverFare", t.DriverFare);
            parameters.Add("FuelOilDay", t.FuelOilDay);
            parameters.Add("FuelOilFare", t.FuelOilFare);
            parameters.Add("GeneralFare", t.GeneralFare);
            parameters.Add("MaintenanceFare", t.MaintenanceFare);
            parameters.Add("OtherFare", t.OtherFare);
            parameters.Add("ServiceFare", t.ServiceFare);
            parameters.Add("RentType", t.RentType);
            parameters.Add("RentFare", t.RentFare);
            parameters.Add("IsActive", t.IsActive);

            return parameters;
        }

        protected override void Initialize(Vehicle t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.IsCompanyVehicle = dr.GetValue<bool>("IsCompanyVehicle");
            t.TitleId = dr.GetValue<int>("TitleId");
            t.DriverFare = dr.GetValue<double>("DriverFare");
            t.FuelOilDay = dr.GetValue<float>("FuelOilDay");
            t.FuelOilFare = dr.GetValue<double>("FuelOilFare");
            t.GeneralFare = dr.GetValue<double>("GeneralFare");
            t.MaintenanceFare = dr.GetValue<double>("MaintenanceFare");
            t.OtherFare = dr.GetValue<double>("OtherFare");
            t.RentType = dr.GetValue<RentTypesEnum>("RentType");
            t.ServiceFare = dr.GetValue<double>("ServiceFare");
            t.RentFare = dr.GetValue<double>("RentFare");
            t.IsActive = dr.GetValue<bool>("IsActive");
        }

    }
}
