using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using NewTemperatureApp.Models;
using NewTemperatureApp3.Helper;
using Newtonsoft.Json;
using UIKit;

namespace NewTemperatureApp4.Tests
{
    public class ImagesClass
    {
        public static string Temperature;
        public Dictionary<string,UIImage> GetImage()
        {
            
            Dictionary<string, UIImage> Weather_dict = new Dictionary<string, UIImage>()
            {
                {"MIST",UIImage.FromBundle("Drawable/Mist.png")},{"HAZE",UIImage.FromBundle("Drawable/Mist.png")},
                {"FEW CLOUDS",UIImage.FromBundle("Drawable/cloudiness.png")},{"SMOKE",UIImage.FromBundle("Drawable/Smoke.png")},
                {"CLEAR SKY",UIImage.FromBundle("Drawable/ClearSky.png")},{"BROKEN CLOUDS",UIImage.FromBundle("Drawable/cloud.png")},
                { "SCATTERED CLOUDS",UIImage.FromBundle("Drawable/cloud.png")},{"OVERCAST CLOUDS",UIImage.FromBundle("Drawable/cloud.png")},
                {"LIGHT SNOW",UIImage.FromBundle("Drawable/Snowlike.png")},{"LIGHT RAIN",UIImage.FromBundle("Drawable/Rainy.png")}
            };

            
             return Weather_dict;

           
        }

        public  string  GetTemperature()
        {
            string result;
            string url1 = $"https://api.openweathermap.org/data/2.5/weather?q=Mumbai&appid=f0259f8bfbab8c0f5ed982170b1b1875";
            //var client = new HttpClient();
            //var request = client.GetType(url1);
            ////  var result = HttpClient.Get(url1);


            WebRequest webRequest = WebRequest.Create(url1);
            webRequest.Method = "GET";
            HttpWebResponse webResponse = null;
            webResponse = (HttpWebResponse)webRequest.GetResponse();
            string srresulttest = null;
            using (Stream stream = webResponse.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                srresulttest = sr.ReadToEnd();
                var WeatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(srresulttest);
                result = WeatherInfo.main.temp.ToString();
                sr.Close();
            }
            return result;

            //var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(request.ToString());
            //Temperature = weatherInfo.main.temp.ToString();

        }
    }
}
