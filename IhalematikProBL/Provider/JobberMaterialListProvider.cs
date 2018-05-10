using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApplicationBase.Toolkit;
using System.Collections;
using IhalematikProBL.Enum;

namespace IhalematikProBL.Provider
{
    public class JobberMaterialListProvider : CustomEntityBaseProvider<JobberMaterialList, JobberMaterialListProvider>
    {
        protected override Hashtable GetCommonParameters(JobberMaterialList t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("JobberTenderId", t.JobberTenderId);
            parameters.Add("MaterialListId", t.MaterialListId);
            parameters.Add("JobberType", t.JobberType);

            return parameters;
        }

        protected override void Initialize(JobberMaterialList t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.MaterialListId = dr.GetValue<int>("MaterialListId");
            t.JobberTenderId = dr.GetValue<int>("JobberTenderId");
            t.JobberType = dr.GetValue<JobberTypesEnum>("JobberTenderId");
        }
    }
}
