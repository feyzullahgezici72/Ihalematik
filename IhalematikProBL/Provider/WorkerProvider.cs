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
            parameters.Add("TravelFareAmount", t.TravelFare.Amount);
            parameters.Add("TravelFareCurrency", t.TravelFare.CurrencyType);

            parameters.Add("SeveranceFareAmount", t.SeveranceFare.Amount);
            parameters.Add("SeveranceFareCurrency", t.SeveranceFare.CurrencyType);
            parameters.Add("IncomeTaxFareAmount", t.IncomeTaxFare.Amount);
            parameters.Add("IncomeTaxFareCurrency", t.IncomeTaxFare.CurrencyType);
            parameters.Add("WorklesFonFareAmount", t.WorklesFonFare.Amount);
            parameters.Add("WorklesFonFareCurrency", t.WorklesFonFare.CurrencyType);


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
            t.TravelFare = new Fare(dr.GetValue<double>("TravelFareAmount"));
            t.SeveranceFare = new Fare(dr.GetValue<double>("SeveranceFareAmount"));
            t.IncomeTaxFare = new Fare(dr.GetValue<double>("IncomeTaxFareAmount"));
            t.WorklesFonFare = new Fare(dr.GetValue<double>("WorklesFonFareAmount"));
            t.IsNormal = dr.GetValue<bool>("IsNormal");
        }
    }
}
