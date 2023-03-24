using System;
using MyFirstBlazor.Models;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyFirstBlazor.Data
{
    public class BrapiService : IDisposable
    {

        private HttpClient? _client;

        public Task<List<string>> GetAvaliableTickers()
        {
            var url = "https://brapi.dev/api/available";
            string jsonResponse = "";

            using (_client = new HttpClient())
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            jsonResponse = reader.ReadToEnd();
                        }
                    }
                }
            }


            JObject obj = JObject.Parse(jsonResponse);
            List<string> stocksList = obj["stocks"].ToObject<List<string>>();

            stocksList.Add("10fiis");

            return Task.FromResult(stocksList);
        }

        public Task<Result> GetBrapiObject(string ticker)
        {
            _client = new HttpClient();
            var url = "https://brapi.dev/api/quote/" + ticker + "?fundamental=true&dividends=true";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            string jsonResponse = "";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        jsonResponse = reader.ReadToEnd();
                    }
                }
            }


            Root stockList = JsonConvert.DeserializeObject<Root>(jsonResponse);
            // do something with newStock


            if (stockList != null && stockList.results.Count() > 0)
            {
                return Task.FromResult(stockList.results[0]);
            }

            return null;
        }





        //internal List<string> GetListTickers(string ticker)
        //{
        //    _client = new HttpClient();
        //    var url = "https://brapi.dev/api/available?search=" + ticker;

        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Method = "GET";
        //    request.ContentType = "application/json";
        //    string jsonResponse = "";

        //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //    {
        //        using (Stream stream = response.GetResponseStream())
        //        {
        //            using (StreamReader reader = new StreamReader(stream))
        //            {
        //                jsonResponse = reader.ReadToEnd();
        //            }
        //        }
        //    }

        //    StocksWrapper stockList = JsonConvert.DeserializeObject<StocksWrapper>(jsonResponse);


        //    if (stockList.Stocks.Count() > 0)
        //        return stockList.Stocks;

        //    return null;
        //}



        public void Dispose()
        {
            _client = null;
            GC.SuppressFinalize(this);
        }
    }
}

