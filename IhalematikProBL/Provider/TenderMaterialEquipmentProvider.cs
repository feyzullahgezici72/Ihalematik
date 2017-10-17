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
    public class TenderMaterialEquipmentProvider : CustomEntityBaseProvider<TenderMaterialEquipment, TenderMaterialEquipmentProvider>
    {
        protected override Hashtable GetCommonParameters(TenderMaterialEquipment t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("EquipmentId", t.EquipmentId);
            parameters.Add("IsWorker", t.IsWorker);
            parameters.Add("MaterialId", t.MaterialId);
            parameters.Add("Quantity", t.Quantity);
            parameters.Add("TenderId", t.TenderId);
            return parameters;
        }

        protected override void Initialize(TenderMaterialEquipment t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.TenderId = dr.GetValue<int>("TenderId");
            t.EquipmentId = dr.GetValue<int>("EquipmentId");
            t.MaterialId = dr.GetValue<int>("MaterialId");
            t.IsWorker = dr.GetValue<bool>("IsWorker");
            t.Quantity = dr.GetValue<double>("Quantity");
        }
    }
}
