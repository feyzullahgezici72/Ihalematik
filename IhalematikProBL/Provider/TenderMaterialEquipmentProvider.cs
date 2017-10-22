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
    public class TenderMaterialListEquipmentProvider : CustomEntityBaseProvider<TenderMaterialListEquipment, TenderMaterialListEquipmentProvider>
    {
        protected override Hashtable GetCommonParameters(TenderMaterialListEquipment t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("EquipmentId", t.EquipmentId);
            parameters.Add("MaterialId", t.MaterialListId);
            parameters.Add("Quantity", t.Quantity);
            parameters.Add("TenderId", t.TenderId);
            return parameters;
        }

        protected override void Initialize(TenderMaterialListEquipment t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.TenderId = dr.GetValue<int>("TenderId");
            t.EquipmentId = dr.GetValue<int>("EquipmentId");
            t.MaterialListId = dr.GetValue<int>("MaterialId");
            t.Quantity = dr.GetValue<double>("Quantity");
        }
    }
}
