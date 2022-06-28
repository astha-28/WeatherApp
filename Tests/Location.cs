using System;
using NewTemperatureApp.Models;
using NewTemperatureApp3.Helper;
using Newtonsoft.Json;

namespace NewTemperatureApp4
{
    public class Location
    {
      
        public string GetWeatherInfo()
        {
            string url1 = $"https://api.openweathermap.org/data/2.5/weather?q=Mumbai&appid=f0259f8bfbab8c0f5ed982170b1b1875";
            return url1;

        }       
    }
}
