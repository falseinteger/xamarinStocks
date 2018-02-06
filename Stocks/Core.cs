using System;
using System.Threading;
using System.Threading.Tasks;

using Stocks.Data;

namespace Stocks
{
    public static class Core
    {
        /// <summary>
        /// Действие когда выполниться обновление валют, при условии что есть данные
        /// </summary>
        public static Action ActionUpdate;
        static Task taskListUpdate;
        static CancellationTokenSource taskListUpdateCancellationTokenSource;


        /// <summary>
        /// Запустить задачу на получение новых/обновление валют
        /// </summary>
        public static void StartUpdateStocks() {

            System.Diagnostics.Debug.WriteLine("[StartUpdateStocks] Create new task update");

            if (taskListUpdateCancellationTokenSource != null)
                taskListUpdateCancellationTokenSource.Cancel();

            taskListUpdateCancellationTokenSource = new CancellationTokenSource();

            taskListUpdate = Task.Factory.StartNew ( async () => {

                System.Diagnostics.Debug.WriteLine("[StartUpdateStocks] send rule CoreWeb");
                var cacheData = await CoreWeb.GetDataCurrency();

                if (cacheData == null)
                    return;

                System.Diagnostics.Debug.WriteLine("[StartUpdateStocks] Have good data");

                // Если пришли данные по валютам обновляем
                Global.DataOfStocks = new DataStocks(cacheData);
                ActionUpdate?.Invoke();

                System.Diagnostics.Debug.WriteLine("[StartUpdateStocks] End");
            }, taskListUpdateCancellationTokenSource.Token);
        }

        /// <summary>
        /// Закрытие всех задач
        /// </summary>
        public static void DisposeUpdateStocks() {

            System.Diagnostics.Debug.WriteLine("[DisposeUpdateStocks] Remove all");

            if (taskListUpdateCancellationTokenSource != null)
                taskListUpdateCancellationTokenSource.Cancel();

            taskListUpdateCancellationTokenSource = null;
            taskListUpdate = null;
        }

    }
}
