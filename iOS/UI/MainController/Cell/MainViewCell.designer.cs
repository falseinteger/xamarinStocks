// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Stocks.iOS
{
    [Register ("MainViewCell")]
    partial class MainViewCell
    {
        [Outlet]
        UIKit.UILabel LabelAmount { get; set; }


        [Outlet]
        UIKit.UILabel LabelNameOfCurrency { get; set; }


        [Outlet]
        UIKit.UILabel LabelVolume { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelAmount != null) {
                LabelAmount.Dispose ();
                LabelAmount = null;
            }

            if (LabelNameOfCurrency != null) {
                LabelNameOfCurrency.Dispose ();
                LabelNameOfCurrency = null;
            }

            if (LabelVolume != null) {
                LabelVolume.Dispose ();
                LabelVolume = null;
            }
        }
    }
}