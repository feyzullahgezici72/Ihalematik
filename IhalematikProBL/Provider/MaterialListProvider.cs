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
    public class MaterialListProvider : CustomEntityBaseProvider<MaterialList, MaterialListProvider>
    {

        protected override Hashtable GetCommonParameters(MaterialList t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Quantity",t.Quantity);
            parameters.Add("PozOBFId", t.PozOBFId);
            parameters.Add("KDVPercentage", t.KDVPercentage);
            parameters.Add("IsPoz", t.IsPoz);
            parameters.Add("IsWorkship", t.IsWorkship); 
            parameters.Add("Markup", t.Markup);
            parameters.Add("WorkerMarkup", t.WorkerMarkup);
            parameters.Add("TenderId", t.TenderId);
            parameters.Add("UnitTimeType", t.UnitTimeType);
            parameters.Add("UnitTime", t.UnitTime);
            parameters.Add("TenderGroupId", t.TenderGroupId);
            parameters.Add("CustomWorkerUnitPrice", t.CustomWorkerUnitPrice);

            return parameters;
        }

        protected override void Initialize(MaterialList t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.IsPoz = dr.GetValue<bool>("IsPoz");
            t.IsWorkship = dr.GetValue<bool>("IsWorkship");
            t.KDVPercentage = dr.GetValue<float>("KDVPercentage");
            t.PozOBFId = dr.GetValue<int>("PozOBFId");
            t.Quantity = dr.GetValue<float>("Quantity");
            t.Markup = dr.GetValue<float>("Markup");
            t.WorkerMarkup = dr.GetValue<float>("WorkerMarkup");
            t.TenderId = dr.GetValue<int>("TenderId");
            t.UnitTime = dr.GetValue<int>("UnitTime");
            t.UnitTimeType = dr.GetValue<UnitTimeTypesEnum>("UnitTimeType");
            t.TenderGroupId = dr.GetValue<int>("TenderGroupId");
            t.CustomWorkerUnitPrice = dr.GetValue<double>("CustomWorkerUnitPrice");
        }
    }
}
