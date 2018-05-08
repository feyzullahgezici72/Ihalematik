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
    public class JobberTenderProvider : CustomEntityBaseProvider<JobberTender, JobberTenderProvider>
    {
        protected override Hashtable GetCommonParameters(JobberTender t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("ContractDate", t.ContractDate);
            parameters.Add("ContractPrice", t.ContractPrice);
            parameters.Add("EndJobDate", t.EndJobDate);
            parameters.Add("JobberId", t.JobberId);
            parameters.Add("JobDescription", t.JobDescription);
            parameters.Add("JobName", t.JobName);
            parameters.Add("StartJobDate", t.StartJobDate);
            parameters.Add("TenderId", t.TenderId);

            return parameters;
        }

        protected override void Initialize(JobberTender t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.ContractDate = dr.GetValue<DateTime?>("ContractDate");
            t.ContractPrice = dr.GetValue<double>("ContractPrice");
            t.EndJobDate = dr.GetValue<DateTime?>("EndJobDate");
            t.JobberId = dr.GetValue<int>("JobberId");
            t.JobDescription = dr.GetValue<string>("JobDescription");
            t.JobName = dr.GetValue<string>("JobName");
            t.StartJobDate = dr.GetValue<DateTime?>("StartJobDate");
            t.TenderId = dr.GetValue<int>("TenderId");
        }
    }
}
