using Foundation;
using NewTemperatureApp.Models;
using NewTemperatureApp3.Helper;
//using NewTemperatureApp4.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using UIKit;
using Xamarin.Essentials;

namespace NewTemperatureApp4
{
    public partial class ViewController : UIViewController
    {

        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public ViewController()
        {
        }

        public float fresult;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            SearchCity.SearchButtonClicked += async (sender, e) =>
            {

                var current = Connectivity.NetworkAccess;
                string Location = SearchCity.Text;
                SearchCity.Text = "";

                if (string.IsNullOrEmpty(Location))
                {
                    var okAlertController = UIAlertController.Create("Message", "Please enter a city name!", UIAlertControllerStyle.Alert);
                    okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                    PresentViewController(okAlertController, true, null);
                }
                else
                {
                    if (current != NetworkAccess.Internet)
                    {
                        var okAlertController = UIAlertController.Create("Message", "No results found!\nPlease check data connection!", UIAlertControllerStyle.Alert);
                        okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                        PresentViewController(okAlertController, true, null);

                    }
                    else
                    {
                        GetWeatherInfo(Location);
                        SearchCity.ResignFirstResponder();
                    }
                }
            };

            //GetForecastInfo();
        }



        /*GetForecastButton.TouchUpInside += (object sender, EventArgs e) =>
        {
            GetForecastInfo();
        };*/


        

            /*foreach (var list in forecastInfo.list)
            {
                var date = DateTime.Parse(list.dt_txt);
                if (date > DateTime.Now && date.Hour == 0 && date.Minute == 0 && date.Second == 0)
                    allList.Add(list);
            }*/
        


        void GetImage()
            {
               Dictionary<string, UIImage> Weather_dict = new Dictionary<string, UIImage>()
            {
                {"MIST",UIImage.FromBundle("Drawable/Mist.png")},{"HAZE",UIImage.FromBundle("Drawable/Mist.png")},
                {"FEW CLOUDS",UIImage.FromBundle("Drawable/cloudiness.png")},{"SMOKE",UIImage.FromBundle("Drawable/Smoke.png")},
                {"CLEAR SKY",UIImage.FromBundle("Drawable/ClearSky.png")},{"BROKEN CLOUDS",UIImage.FromBundle("Drawable/cloud.png")},
                { "SCATTERED CLOUDS",UIImage.FromBundle("Drawable/cloud.png")},{"OVERCAST CLOUDS",UIImage.FromBundle("Drawable/cloud.png")},
                {"LIGHT SNOW",UIImage.FromBundle("Drawable/Snowlike.png")},{"LIGHT RAIN",UIImage.FromBundle("Drawable/Rainy.png")}
            };

                foreach (KeyValuePair<string, UIImage> n in Weather_dict)
                {
                    if (DescriptionLabel.Text == n.Key)
                    {
                        ImageLabel.Image = n.Value;
                    }

                }

            }       

            public async void GetWeatherInfo(string Location = " ")
            {
                try
                {
                    string url1 = $"https://api.openweathermap.org/data/2.5/weather?q={Location}&appid=f0259f8bfbab8c0f5ed982170b1b1875";
                    var result = await ApiCaller.Get(url1);
                    var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result.Response);
                    string Temp = weatherInfo.main.temp.ToString();
                    float temp1 = float.Parse(Temp);
                    fresult = temp1 - 273;
                    TemperatureLabel.Text = fresult.ToString("0°C");
                    CityLabel.Text = weatherInfo.name.ToUpper();
                    DescriptionLabel.Text = weatherInfo.Weather[0].description.ToUpper();
                    //var dt1 = new DateTime().ToUniversalTime().AddSeconds(weatherInfo.dt);
                    DateTimeLabel.Text = DateTime.Now.ToString("dddd, MMM dd").ToUpper();
                    GetImage();
                   
                }
                catch
                {
                    var okAlertController = UIAlertController.Create("Message", "No results found!\nPlease enter a valid city name.", UIAlertControllerStyle.Alert);
                    okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                    PresentViewController(okAlertController, true, null);
                }

            }

        /*public float GetTemperature()
        {
            GetWeatherInfo("mumbai");
            return fresult;
        }*/

        

        

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}
