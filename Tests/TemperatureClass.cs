using System;
using System.Threading.Tasks;
using NewTemperatureApp.Models;
using NewTemperatureApp3.Helper;
using Newtonsoft.Json;

namespace NewTemperatureApp4.Tests
{
    public class TemperatureClass
    {
        public static string Temperature;

        public string GetTemperature1()
        {
            string url1 = $"https://api.openweathermap.org/data/2.5/weather?q=Mumbai&appid=f0259f8bfbab8c0f5ed982170b1b1875";
            var result = ApiCaller.Get(url1);
            var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(result.ToString());
            Temperature = weatherInfo.main.temp.ToString();
            return Temperature;
        }



    }
}
