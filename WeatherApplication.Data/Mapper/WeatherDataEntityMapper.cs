using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WeatherApplication.Data.Interfaces;
using WeatherApplication.Data.Model;
using WeatherApplication.Domain.Entities;

namespace WeatherApplication.Data.Mapper
{
    public class WeatherDataEntityMapper : IMapper<WeatherData, WeatherEntity>
    {
        public WeatherEntity MapFrom([NotNull] WeatherData input)
        {
            return new WeatherEntity
            {
                MinTemperature = input.Main.TempMin,
                MaxTemperature = input.Main.TempMax,
                Description = input.Weather[0].Description
            };
        }
    }
}
