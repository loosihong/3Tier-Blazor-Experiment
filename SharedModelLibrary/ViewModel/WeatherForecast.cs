using System;
using System.Text.Json.Serialization;

namespace SharedModelLibrary.ViewModel
{
    public class WeatherForecast
    {
        [JsonPropertyName(nameof(Date))]
        public DateTime Date { get; set; }
        [JsonPropertyName(nameof(TemperatureC))]
        public int TemperatureC { get; set; }
        [JsonPropertyName(nameof(TemperatureF))]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        [JsonPropertyName(nameof(Summary))]
        public string Summary { get; set; }
    }
}
