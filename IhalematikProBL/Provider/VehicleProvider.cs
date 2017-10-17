using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class VehicleProvider : CustomEntityBaseProvider<Vehicle, VehicleProvider>
    {
        protected override Hashtable GetCommonParameters(Vehicle t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("HourPrice", t.HourPrice);
            parameters.Add("IsCompanyVehicle", t.IsCompanyVehicle);
            parameters.Add("OtherPrice", t.OtherPrice);
            parameters.Add("TitleId", t.TitleId);
            parameters.Add("WorkHour", t.WorkHour);

            return parameters;
        }

        protected override void Initialize(Vehicle t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.HourPrice = dr.GetValue<float>("HourPrice");
            t.IsCompanyVehicle = dr.GetValue<bool>("IsCompanyVehicle");
            t.OtherPrice = dr.GetValue<float>("OtherPrice");
            t.TitleId = dr.GetValue<int>("TitleId");
            t.WorkHour = dr.GetValue<float>("WorkHour");
        }

    }
}
