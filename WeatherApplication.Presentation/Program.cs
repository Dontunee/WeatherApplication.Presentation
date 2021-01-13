using Ninject;
using System;
using WeatherApplication.Domain.UseCases;

namespace WeatherApplication.Presentation
{
    class Program
    {
        internal void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new WeatherModule());
            var useCase = kernel.Get<GetWeatherInteractor>();
            const string city = "Harare";
            var weather = useCase.Handle(city);
            Console.WriteLine($"Weather for {city}");
            Console.WriteLine($"Description: {weather.Description}°C");
            Console.WriteLine($"Min temp : {weather.MinTemperature}°C");
            Console.WriteLine($"Max temp : {weather.MaxTemperature}°C");
            Console.ReadLine();
        }
    }
}
