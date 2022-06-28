using System;
using System.Collections.Generic;
using Foundation;
using NewTemperatureApp.Models;
using UIKit;

namespace NewTemperatureApp4
{
    public class MyTableViewSource: UITableViewSource
    {
        List<string> cityNames;

        public MyTableViewSource(List<string> cityNames)
        {
            this.cityNames = cityNames;
        }

        //string cellidentifier = "WeatherCell";
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            cell.TextLabel.Text = cityNames[indexPath.Row];
            return cell;
        }


        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return cityNames.Count;
        }
    }
}
