using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.BL.Base;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class VehicleTitleProvider : CustomEntityBaseProvider<VehicleTitle, VehicleTitleProvider>
    {
        public VehicleTitleProvider()
        {
            this.EnableCaching = true;
        }
        protected override Hashtable GetCommonParameters(VehicleTitle t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Name", t.Name);
            return parameters;
        }

        protected override void Initialize(VehicleTitle t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Name = dr.GetValue<string>("Name");
        }
    }
}
