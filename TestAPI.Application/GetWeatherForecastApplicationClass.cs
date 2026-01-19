using System;
using TestAPI.Domain;

namespace TestAPI.Application
{
	public class GetWeatherForecastApplicationClass
	{
		private readonly WeatherForecastRepository weatherForecastRepository;
		public GetWeatherForecastApplicationClass(WeatherForecastRepository _weatherForecastRepository)
		{
			weatherForecastRepository = _weatherForecastRepository;
		}

		public async Task<IEnumerable<WeatherForecast>> GetWeatherAsync()
		{
			var data = await weatherForecastRepository.Get();
			return data;
		}
	}
}

