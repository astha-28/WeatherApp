// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NewTemperatureApp4
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel CityLabel { get; set; }

		[Outlet]
		UIKit.UILabel DateTimeLabel { get; set; }

		[Outlet]
		UIKit.UILabel DescriptionLabel { get; set; }

		[Outlet]
		UIKit.UIButton GetForecastButton { get; set; }

		[Outlet]
		UIKit.UIImageView ImageLabel { get; set; }

		[Outlet]
		UIKit.UISearchBar SearchCity { get; set; }

		[Outlet]
		UIKit.UILabel TemperatureLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CityLabel != null) {
				CityLabel.Dispose ();
				CityLabel = null;
			}

			if (DateTimeLabel != null) {
				DateTimeLabel.Dispose ();
				DateTimeLabel = null;
			}

			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}

			if (ImageLabel != null) {
				ImageLabel.Dispose ();
				ImageLabel = null;
			}

			if (SearchCity != null) {
				SearchCity.Dispose ();
				SearchCity = null;
			}

			if (TemperatureLabel != null) {
				TemperatureLabel.Dispose ();
				TemperatureLabel = null;
			}

			if (GetForecastButton != null) {
				GetForecastButton.Dispose ();
				GetForecastButton = null;
			}
		}
	}
}
