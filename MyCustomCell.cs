/*using System;
using UIKit;
using Foundation;
using CoreGraphics;
using NewTemperatureApp3.Helper;
using Newtonsoft.Json;
using NewTemperatureApp.Models;
using System.Collections.Generic;

namespace NewTemperatureApp4
{
    public class MyCustomCell : UITableViewCell
    {
        UILabel headingLabel1, headingLabel2;
        public MyCustomCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Blue;
            ContentView.BackgroundColor = UIColor.Cyan;
            headingLabel1 = new UILabel()
            {
                Font = UIFont.FromName("Helvetica", 12f),
                TextColor = UIColor.Red,
                BackgroundColor = UIColor.Clear
            };
            headingLabel2 = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextAlignment = UITextAlignment.Center,
                TextColor = UIColor.Blue,
                BackgroundColor = UIColor.Clear
            };
            ContentView.AddSubviews(new UIView[] { headingLabel1, headingLabel2});
        }

       

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            headingLabel1.Frame = new CGRect(5, 4, ContentView.Bounds.Width, 25);
            headingLabel2.Frame = new CGRect(100, 22, 100, 20);
            
        }

        /*public void UpdateCell(string _headingLabel1, string _headingLabel2)
        {
            headingLabel1.Text = _headingLabel1;
            headingLabel2.Text = _headingLabel2;
            
        }*/

        /*public void UpdateCell(ForecastInfo forecastinfo)
        {
            headingLabel1.Text = allList[0].main.temp.ToString("0");
            headingLabel2.Text = DateTime.Parse(allList[0].dt_txt).ToString("dddd");

        }
        
    }
}*/
