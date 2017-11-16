using IhalematikProBL.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;

namespace IhalematikProBL.Provider
{
    public class SupplierSegmentProvider : CustomEntityBaseProvider<SupplierSegment, SupplierSegmentProvider>
    {
        public SupplierSegmentProvider()
        {
            this.EnableCaching = true;
        }
        protected override Hashtable GetCommonParameters(SupplierSegment t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Name", t.Name);
            return parameters;
        }

        protected override void Initialize(SupplierSegment t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Name = dr.GetValue<string>("Name");
        }
    }
}
