using System;
using System.Net.Http;

using Stocks.Data;

namespace Stocks
{
    public static class Global
    {
        static HttpClient _WebClient { get; set; }
        public static HttpClient WebClient
        {
            get {
                return _WebClient ?? (_WebClient = new HttpClient());
            }
        }

        public static string LinkToDataCurrecy = "http://phisix-api3.appspot.com/stocks.json";


        public static DataStocks DataOfStocks;
    }
}
