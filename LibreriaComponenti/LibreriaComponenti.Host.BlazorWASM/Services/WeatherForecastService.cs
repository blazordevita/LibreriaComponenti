using LibreriaComponenti.Models;
using LibreriaComponenti.Services;
using System.Net.Http.Json;

namespace LibreriaComponenti.Host.BlazorWASM.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _http;

        public WeatherForecastService(HttpClient http)
        {
            _http = http;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return _http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}
