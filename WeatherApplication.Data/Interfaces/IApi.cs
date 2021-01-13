using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Model;

namespace WeatherApplication.Data.Interfaces
{
    public interface IApi
    {
        WeatherData GetWeatherData(string cityName);
    }
}
