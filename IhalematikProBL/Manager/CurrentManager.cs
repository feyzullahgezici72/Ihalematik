using IhalematikProBL.Entity;
using IhalematikProBL.Enum;
using IhalematikProBL.Provider;
using SimpleApplicationBase.BL.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhalematikProBL.Manager
{
    public class CurrentManager : SingletonBase<CurrentManager>
    {
        public ExchangeRate CurrentExchangeRateUSD
        {
            get
            {
                ExchangeRate result = new ExchangeRate();
                List<ExchangeRate> exchangeRatesUSD = ExchangeRateProvider.Instance.GetItems("CurrencyType", CurrencyTypesEnum.USD);
                if (exchangeRatesUSD.Count == 0)
                {
                    double usd = double.Parse(this.GetRate("USD").ToString());
                    result.UnitPrice = usd;
                    result.CurrencyType = CurrencyTypesEnum.USD;
                    return result;
                }
                else
                {
                    return exchangeRatesUSD.OrderByDescending(p => p.InsertTime).FirstOrDefault();
                }
            }
        }

        public ExchangeRate CurrentExchangeRateEUR
        {
            get
            {
                ExchangeRate result = new ExchangeRate();
                List<ExchangeRate> exchangeRatesEUR = ExchangeRateProvider.Instance.GetItems("CurrencyType", CurrencyTypesEnum.EUR);
                if (exchangeRatesEUR.Count == 0)
                {
                    double euro = double.Parse(this.GetRate("EUR").ToString());
                    result.UnitPrice = euro;
                    result.CurrencyType = CurrencyTypesEnum.EUR;
                    return result;
                }
                else
                {
                    return exchangeRatesEUR.OrderByDescending(p => p.InsertTime).FirstOrDefault();
                }
            }
        }

        public decimal GetRate(string code)
        {
            string url = string.Empty;
            var date = DateTime.Now;
            if (date.Date == DateTime.Today)
                url = "http://www.tcmb.gov.tr/kurlar/today.xml";
            else
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}{1}/{2}{1}{0}.xml", date.Year, addZero(date.Month), addZero(date.Day));

            System.Xml.Linq.XDocument document = System.Xml.Linq.XDocument.Load(url);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var result = document.Descendants("Currency")
            .Where(v => v.Element("ForexBuying") != null && v.Element("ForexBuying").Value.Length > 0)
            .Select(v => new Currency
            {
                Code = v.Attribute("Kod").Value,
                Rate = decimal.Parse(v.Element("ForexBuying").Value)
            }).ToList();
            return result.FirstOrDefault(s => s.Code == code).Rate;
        }
        private string addZero(int p)
        {
            if (p.ToString().Length == 1)
                return "0" + p;
            return p.ToString("c4");
        }
        public class Currency
        {
            public string Code { get; set; }
            public decimal Rate { get; set; }
        }
    }
}
