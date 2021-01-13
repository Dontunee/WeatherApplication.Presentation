using Moq;
using NUnit.Framework;
using System;
using WeatherApplication.Domain.Entities;
using WeatherApplication.Domain.Interfaces;
using WeatherApplication.Domain.UseCases;

namespace WeatherApplication.Domain.Test
{
    public class UseCaseTests
    {
        private readonly WeatherEntity _weather = new WeatherEntity
        {
            Description = "Cloudy",
            MaxTemperature = 50,
            MinTemperature = 100
        };

        private GetWeatherInteractor _interactor;

        [OneTimeSetUp]
        public void Setup()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetWeather("Harare")).Returns(_weather);
            _interactor = new GetWeatherInteractor(mock.Object);

        }

        [Test]
        public void TestGetWeather()
        {
            var result = _interactor.Handle("Harare");
            Assert.NotNull(result);
            Assert.AreEqual(result.MaxTemperature, _weather.MaxTemperature);
            Assert.AreEqual(result.MinTemperature, _weather.MinTemperature);
            Assert.AreEqual(result.Description, _weather.Description);
        }
    }
}
