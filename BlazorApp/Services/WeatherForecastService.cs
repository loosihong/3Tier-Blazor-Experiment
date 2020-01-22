using System;
using System.Threading.Tasks;
using System.Net.Http;
using SharedModelLibrary.ViewModel;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace BlazorApp
{
    public class WeatherForecastService
    {
        private readonly HttpClient _httpClient;
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        public WeatherForecastService(HttpClient client)
        {
            this._httpClient = client;
        }

        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate)
        {
            HttpResponseMessage response = await this._httpClient.GetAsync("weatherforecast");
            response.EnsureSuccessStatusCode();
            IEnumerable<WeatherForecast> forecasts = null;

            using (Stream responseContent = await response.Content.ReadAsStreamAsync())
            {
                forecasts = await JsonSerializer.DeserializeAsync<IEnumerable<WeatherForecast>>(responseContent);
            }

            return forecasts;
        }
    }
}
