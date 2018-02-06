using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stocks.Data;

namespace Stocks
{
    public static class CoreWeb
    {

        /// <summary>
        /// Получить посление изменения по валютам
        /// </summary>
        /// <returns>The data currency.</returns>
        public static async Task<DataStocks> GetDataCurrency()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("[GetDataCurrency] Start");
                var respone = await Global.WebClient.GetAsync(Global.LinkToDataCurrency);
                var resultContent = await respone.Content.ReadAsStringAsync();

                if(respone.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    System.Diagnostics.Debug.WriteLine("[GetDataCurrency] Status bad");
                    System.Diagnostics.Debug.WriteLine(resultContent);
                    return null;
                }

                var dataDeserialize = JsonConvert.DeserializeObject<DataStocks>(resultContent);

                System.Diagnostics.Debug.WriteLine("[GetDataCurrency] Success get data");
                return dataDeserialize;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("[GetDataCurrency] Exception");
                System.Diagnostics.Debug.WriteLine(ex);
                return null;
            }
        }

    }
}
