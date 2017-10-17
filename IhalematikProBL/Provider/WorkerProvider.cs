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
    public class WorkerProvider : CustomEntityBaseProvider<Worker, WorkerProvider>
    {
        protected override Hashtable GetCommonParameters(Worker t)
        {
            Hashtable parameters = base.GetCommonParameters(t);

            parameters.Add("TitleId", t.TitleId);
            parameters.Add("Code", t.Code);
            parameters.Add("IsNormal", t.IsNormal);

            parameters.Add("AGIFareAmount", t.AGIFare.Amount);
            parameters.Add("AGIFareCurrency", t.AGIFare.CurrencyType);
            parameters.Add("BaseFareAmount", t.BaseFare.Amount);
            parameters.Add("BaseFareCurrency", t.BaseFare.CurrencyType);
            parameters.Add("ExtraFareAmount", t.ExtraFare.Amount);
            parameters.Add("ExtraFareCurrency", t.ExtraFare.CurrencyType);
            parameters.Add("FoodFareAmount", t.FoodFare.Amount);
            parameters.Add("FoodFareCurrency", t.FoodFare.CurrencyType);
            parameters.Add("HotelFareAmount", t.HotelFare.Amount);
            parameters.Add("HotelFareCurrency", t.HotelFare.CurrencyType);
            parameters.Add("ISGFareAmount", t.ISGFare.Amount);
            parameters.Add("ISGFareCurrency", t.ISGFare.CurrencyType);
            parameters.Add("SGKPrimFareAmount", t.SGKPrimFare.Amount);
            parameters.Add("SGKPrimFareCurrency", t.SGKPrimFare.CurrencyType);
            parameters.Add("StampTaxFareAmount", t.StampTaxFare.Amount);
            parameters.Add("StampTaxFareCurrency", t.StampTaxFare.CurrencyType);
            parameters.Add("StopajFareAmount", t.StopajFare.Amount);
            parameters.Add("StopajFareCurrency", t.StopajFare.CurrencyType);
            parameters.Add("TravelFareAmount", t.TravelFare.Amount);
            parameters.Add("TravelFareCurrency", t.TravelFare.CurrencyType);

            return parameters;
        }

        protected override void Initialize(Worker t, Dictionary<string, object> dr)
        {
            base.Initialize(t, dr);
            t.TitleId = dr.GetValue<int>("TitleId");
            t.AGIFare = new Fare(dr.GetValue<double>("AGIFareAmount"));
            t.BaseFare = new Fare(dr.GetValue<double>("BaseFareAmount"));
            t.ExtraFare = new Fare(dr.GetValue<double>("ExtraFareAmount"));
            t.FoodFare = new Fare(dr.GetValue<double>("FoodFareAmount"));
            t.HotelFare = new Fare(dr.GetValue<double>("HotelFareAmount"));
            t.ISGFare = new Fare(dr.GetValue<double>("ISGFareAmount"));
            t.SGKPrimFare = new Fare(dr.GetValue<double>("SGKPrimFareAmount"));
            t.StampTaxFare = new Fare(dr.GetValue<double>("StampTaxFareAmount"));
            t.StopajFare = new Fare(dr.GetValue<double>("StopajFareAmount"));
            t.TravelFare = new Fare(dr.GetValue<double>("TravelFareAmount"));
            t.IsNormal = dr.GetValue<bool>("IsNormal");
        }
    }
}
