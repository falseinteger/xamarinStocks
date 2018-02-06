using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Stocks.Data
{
    public class DataStocks
    {

        public DataStocks() {}

        public DataStocks(DataStocks newItem) {
            Stocks = newItem.Stocks;
            AsOf = newItem.AsOf;
        }

        [JsonProperty("stock")]
        public IList<ItemStock> Stocks { get; set; }

        [JsonProperty("as_of")]
        public DateTime AsOf { get; set; }
    }

    public class ItemStock
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("price")]
        public Price Price { get; set; }
        [JsonProperty("percent_change")]
        public double PercentChange { get; set; }
        [JsonProperty("volume")]
        public int Volume { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }

    public class Price
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}
