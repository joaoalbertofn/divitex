using System;

namespace MyFirstBlazor.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CashDividend
    {
        public string assetIssued { get; set; }
        public DateTime paymentDate { get; set; }
        public DateTime approvedOn { get; set; }
        public DateTime lastDatePrior { get; set; }
        public double rate { get; set; }
        public string relatedTo { get; set; }
        public string isinCode { get; set; }
        public string label { get; set; }
        public string remarks { get; set; }
    }

    public class DividendsData
    {
        public List<CashDividend> cashDividends { get; set; }
        public List<StockDividend> stockDividends { get; set; }
        public List<Subscription> subscriptions { get; set; }
    }

    public class Result
    {
        public string symbol { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string currency { get; set; }
        public double regularMarketPrice { get; set; }
        public double regularMarketDayHigh { get; set; }
        public double regularMarketDayLow { get; set; }
        public string regularMarketDayRange { get; set; }
        public double regularMarketChange { get; set; }
        public double regularMarketChangePercent { get; set; }
        public DateTime regularMarketTime { get; set; }
        public long marketCap { get; set; }
        public double regularMarketVolume { get; set; }
        public double regularMarketPreviousClose { get; set; }
        public double regularMarketOpen { get; set; }
        public double averageDailyVolume10Day { get; set; }
        public double averageDailyVolume3Month { get; set; }
        public double fiftyTwoWeekLowChange { get; set; }
        public string fiftyTwoWeekRange { get; set; }
        public double fiftyTwoWeekHighChange { get; set; }
        public double fiftyTwoWeekHighChangePercent { get; set; }
        public double fiftyTwoWeekLow { get; set; }
        public double fiftyTwoWeekHigh { get; set; }
        public double twoHundredDayAverage { get; set; }
        public double twoHundredDayAverageChange { get; set; }
        public double twoHundredDayAverageChangePercent { get; set; }
        public object priceEarnings { get; set; }
        public object earningsPerShare { get; set; }
        public string logourl { get; set; }
        public DividendsData dividendsData { get; set; }


        //public double GetCurrentUpsiteDownside()
        //{

        //}

        public List<double> GetDividendData()
        {
            List<double> list = new List<double>();

            if (this.dividendsData is null) return list;

            List<CashDividend> cashDividendList = this.dividendsData.cashDividends.OrderBy(cd => cd.paymentDate).ToList();

            foreach (CashDividend dividend in cashDividendList)
            {
                list.Add(dividend.rate);
            }

            return list;
        }

        public List<string> GetDividendMonths()
        {
            List<string> list = new List<string>();

            if (this.dividendsData is null) return list;

            List<CashDividend> cashDividendList = this.dividendsData.cashDividends.OrderBy(cd => cd.paymentDate).ToList();

            foreach (CashDividend dividend in cashDividendList)
            {
                list.Add(dividend.paymentDate.ToString("MMM/yy").ToUpper().Replace(".",string.Empty));
            }

            return list;
        }
    }

    public class Root
    {
        public List<Result> results { get; set; }
        public DateTime requestedAt { get; set; }
    }

    public class StockDividend
    {
        public string assetIssued { get; set; }
        public int factor { get; set; }
        public DateTime approvedOn { get; set; }
        public string isinCode { get; set; }
        public string label { get; set; }
        public DateTime lastDatePrior { get; set; }
        public string remarks { get; set; }
    }

    public class Subscription
    {
        public string assetIssued { get; set; }
        public double percentage { get; set; }
        public double priceUnit { get; set; }
        public string tradingPeriod { get; set; }
        public DateTime subscriptionDate { get; set; }
        public DateTime approvedOn { get; set; }
        public string isinCode { get; set; }
        public string label { get; set; }
        public DateTime lastDatePrior { get; set; }
        public string remarks { get; set; }
    }




}

