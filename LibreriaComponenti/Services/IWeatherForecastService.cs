using System;
using System.Threading.Tasks;
using LibreriaComponenti.Models;

namespace LibreriaComponenti.Services
{
    public interface IWeatherForecastService
    {
         Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}