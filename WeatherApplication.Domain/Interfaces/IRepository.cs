using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Domain.Entities;

namespace WeatherApplication.Domain.Interfaces
{
    public interface IRepository
    {
        WeatherEntity GetWeather(string cityName);
    }

}
