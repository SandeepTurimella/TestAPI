using System;
using Microsoft.Extensions.DependencyInjection;
using TestAPI.Application;

namespace TestAPI.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            services.AddScoped<WeatherForecastRepository, GetWeatherForecastInfrastructureClass>();

            return services;
        }
    }
}

