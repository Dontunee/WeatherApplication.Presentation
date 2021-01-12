using System;
using System.Collections.Generic;
using System.Text;
using WeatherApplication.Domain.Entities;
using WeatherApplication.Interfaces.UseCases;

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


    }
}
