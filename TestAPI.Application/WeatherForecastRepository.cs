using System;
using TestAPI.Domain;

namespace TestAPI.Application
{
	public interface WeatherForecastRepository
	{
        Task<IEnumerable<WeatherForecast>> Get();
    }
}

