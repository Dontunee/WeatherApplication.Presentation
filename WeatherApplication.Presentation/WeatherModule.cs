using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WeatherApplication.Data.Interfaces;
using WeatherApplication.Data.Mapper;
using WeatherApplication.Data.Model;
using WeatherApplication.Data.Services;
using WeatherApplication.Domain.Entities;
using WeatherApplication.Domain.Interfaces;
using WeatherApplication.Domain.UseCases;

namespace WeatherApplication.Presentation
{
    public class WeatherModule : NinjectModule
    {
        public override void Load()
        {
            var apiKey = ConfigurationManager.AppSettings["API_KEY"];
            Bind<IMapper<WeatherData, WeatherEntity>>().To<WeatherDataEntityMapper>();
            Bind<IApi>().To<OpenWeatherApi>().WithConstructorArgument("apiKey", apiKey);
            Bind<IRepository>().To<WeatherRepository>();
            Bind<GetWeatherInteractor>().ToSelf().InSingletonScope();
        }
    }
}
