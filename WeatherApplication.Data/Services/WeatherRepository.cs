using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WeatherApplication.Data.Interfaces;
using WeatherApplication.Data.Model;
using WeatherApplication.Domain.Entities;
using WeatherApplication.Domain.Interfaces;

namespace WeatherApplication.Data.Services
{
    public class WeatherRepository : IRepository
    {
        private readonly IApi _api;
        private readonly IMapper<WeatherData, WeatherEntity> _mapper;

        public WeatherRepository(IApi api, IMapper<WeatherData, WeatherEntity> mapper)
        {
            _api = api ?? throw new ArgumentNullException(nameof(api));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public WeatherEntity GetWeather([NotNull] string cityName)
        {
            return _mapper.MapFrom(_api.GetWeatherData(cityName));
        }
    }
}
