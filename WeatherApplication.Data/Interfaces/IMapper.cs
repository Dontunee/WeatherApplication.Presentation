using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Data.Model;
using WeatherApplication.Domain.Entities;

namespace WeatherApplication.Data.Interfaces
{
    public interface IMapper <T1, T2>
    {
        WeatherEntity MapFrom(T1 input);

    }
}
