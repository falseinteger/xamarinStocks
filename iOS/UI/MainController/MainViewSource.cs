using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;

using Stocks.Data;

namespace Stocks.iOS
{
    public class MainViewSource : UITableViewSource
    {
        List<ItemStock> Items;

        /// <summary>
        /// Иницилицаия списка валют
        /// </summary>
        /// <param name="newItems">New items.</param>
        public MainViewSource(IList<ItemStock> newItems)
        {
            UpdateItems(newItems);
        }

        /// <summary>
        /// Обновить список валют
        /// </summary>
        /// <param name="newItems">New items.</param>
        public void UpdateItems(IList<ItemStock> newItems)
        {
            Items = newItems == null ? new List<ItemStock>() : newItems.ToList();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("MainViewCell") as MainViewCell;

            if (cell == null)
                return new UITableViewCell();

            var item = Items.ElementAt(indexPath.Row);

            cell.LoadView(item);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Items == null ? 0 : Items.Count;
        }
    }
}
