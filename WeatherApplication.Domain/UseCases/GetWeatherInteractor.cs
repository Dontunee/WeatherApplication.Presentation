using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using WeatherApplication.Domain.Entities;
using WeatherApplication.Domain.Interfaces;

namespace WeatherApplication.Domain.UseCases
{
    internal interface IRequestHandler<in TRequest, out TResponse>
    {
        TResponse Handle(TRequest data);
    }
    public class GetWeatherInteractor : IRequestHandler<string,Weather>
    {

        private readonly IRepository _repository;

        public GetWeatherInteractor(IRepository repository)
        {
            _repository = repository;
        }

        public Weather Handle([NotNull] string data)
        {
            return _repository.GetWeather(data);
        }
    }
}
