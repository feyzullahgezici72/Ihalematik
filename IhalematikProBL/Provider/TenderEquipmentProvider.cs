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
    public class TenderEquipmentProvider : CustomEntityBaseProvider<TenderEquipment, TenderEquipmentProvider>
    {
        protected override Hashtable GetCommonParameters(TenderEquipment t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("IsWorker", t.IsWorker);
            parameters.Add("TenderId", t.TenderId);
            parameters.Add("WorkerVehicleId", t.WorkerVehicleId);
            parameters.Add("Quantity", t.Quantity);
            return parameters;
        }

        protected override void Initialize(TenderEquipment t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.IsWorker = dr.GetValue<bool>("IsWorker");
            t.TenderId = dr.GetValue<int>("TenderId");
            t.Quantity = dr.GetValue<int>("Quantity");
            t.WorkerVehicleId = dr.GetValue<int>("WorkerVehicleId");
        }
    }
}
