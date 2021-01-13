using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Interfaces;
using WeatherApplication.Data.Model;

namespace WeatherApplication.Data.Services
{
    public class OpenWeatherApi : IApi
    {
        public WeatherData GetWeatherData(string cityName)
        {
            return new WeatherData()
            {
                Main = new Main()
                {
                    TempMax = 20,
                    TempMin = 100,
                },
                Weather = new Weather[0]
            };
        }
    }
}
