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
    public class OfferMaterialListProvider : CustomEntityBaseProvider<OfferMaterialList, OfferMaterialListProvider>
    {
        protected override Hashtable GetCommonParameters(OfferMaterialList t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("IsPoz", t.IsPoz);
            parameters.Add("OfferId", t.OfferId);
            parameters.Add("PozOBFId", t.PozOBFId);
            parameters.Add("Quantity", t.Quantity);
            parameters.Add("IsSelected", t.IsSelected);
            return parameters;
        }

        protected override void Initialize(OfferMaterialList t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.IsPoz = dr.GetValue<bool>("IsPoz");
            t.OfferId = dr.GetValue<int>("OfferId");
            t.PozOBFId = dr.GetValue<int>("PozOBFId");
            t.Quantity = dr.GetValue<float>("Quantity");
            t.IsSelected = dr.GetValue<bool>("IsSelected");

            //t.Price = dr.GetValue<double>("Price");
        }
    }
}
