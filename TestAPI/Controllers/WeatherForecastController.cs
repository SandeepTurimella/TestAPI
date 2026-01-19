using Microsoft.AspNetCore.Mvc;
using TestAPI.Application;
using TestAPI.Domain;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly GetWeatherForecastApplicationClass getWeatherForecastApplicationClass;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, GetWeatherForecastApplicationClass _getWeatherForecastApplicationClass)
    {
        _logger = logger;
        getWeatherForecastApplicationClass = _getWeatherForecastApplicationClass;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await getWeatherForecastApplicationClass.GetWeatherAsync();
    }
}

