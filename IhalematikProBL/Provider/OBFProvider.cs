using IhalematikProBL.Entity;
using System.Collections.Generic;
using System.Collections;
using SimpleApplicationBase.Toolkit;
using IhalematikProBL.Manager;
using IhalematikProBL.Enum;

namespace IhalematikProBL.Provider
{
    public class OBFProvider : CustomEntityBaseProvider<OBF, OBFProvider>
    {
        protected override Hashtable GetCommonParameters(OBF t)
        {
            Hashtable parameters = base.GetCommonParameters(t);
            parameters.Add("Description", t.Description);
            parameters.Add("Number", t.Number);
            parameters.Add("Unit", t.Unit);
            parameters.Add("UnitPrice", t.UnitPrice);
            parameters.Add("IsActive", t.IsActive);
            parameters.Add("DescriptionForSupplier", t.DescriptionForSupplier);
            parameters.Add("StokNumber", t.StokNumber);
            parameters.Add("ParentId", t.ParentId);
            parameters.Add("CurrencyType", t.CurrencyType);
            return parameters;
        }

        protected override void Initialize(OBF t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.Description = dr.GetValue<string>("Description");
            t.Number = dr.GetValue<string>("Number");
            t.Unit = dr.GetValue<string>("Unit");
            t.CurrencyType = dr.GetValue<CurrencyTypesEnum>("CurrencyType");

            double unitPrice = dr.GetValue<double>("UnitPrice");

            switch (t.CurrencyType)
            {
                case CurrencyTypesEnum.TL:
                    t.UnitPrice = unitPrice;
                    break;
                case CurrencyTypesEnum.USD:
                    t.UnitPrice = unitPrice * CurrentManager.Instance.CurrentExchangeRateUSD.UnitPrice;
                    break;
                case CurrencyTypesEnum.EUR:
                    t.UnitPrice = unitPrice * CurrentManager.Instance.CurrentExchangeRateEUR.UnitPrice;
                    break;
                default:
                    t.UnitPrice = unitPrice;
                    break;
            }


            t.IsActive = dr.GetValue<bool>("IsActive");
            t.DescriptionForSupplier = dr.GetValue<string>("DescriptionForSupplier");
            t.StokNumber = dr.GetValue<string>("StokNumber");
            t.ParentId = dr.GetValue<int>("ParentId");
        }

        public void UpdateOBFPrice(int Id, double UnitPrice)
        {
            Hashtable param = new Hashtable();
            param.Add("UnitPrice", UnitPrice);
            param.Add("CurrencyType", CurrencyTypesEnum.TL);
            param.Add("Id", Id);

            CustomDBConnectionManager.Instance.ExecuteNonQuery("OBFPriceUpdate", param);
        }
    }
}
