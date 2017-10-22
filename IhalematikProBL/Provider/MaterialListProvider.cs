﻿using IhalematikProBL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SimpleApplicationBase.Toolkit;

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
            parameters.Add("Markup", t.Markup);
            parameters.Add("TenderId", t.TenderId);
            return parameters;
        }

        protected override void Initialize(MaterialList t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.IsPoz = dr.GetValue<bool>("IsPoz");
            t.KDVPercentage = dr.GetValue<float>("KDVPercentage");
            t.PozOBFId = dr.GetValue<int>("PozOBFId");
            t.Quantity = dr.GetValue<float>("Quantity");
            t.Markup = dr.GetValue<float>("Markup");
            t.TenderId = dr.GetValue<int>("TenderId");
        }
    }
}
