// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Stocks.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem ButtonRefreshing { get; set; }

		[Outlet]
		UIKit.UILabel LabelInfoData { get; set; }

		[Outlet]
		UIKit.UITableView TableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ButtonRefreshing != null) {
				ButtonRefreshing.Dispose ();
				ButtonRefreshing = null;
			}

			if (LabelInfoData != null) {
				LabelInfoData.Dispose ();
				LabelInfoData = null;
			}

			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}
		}
	}
}
