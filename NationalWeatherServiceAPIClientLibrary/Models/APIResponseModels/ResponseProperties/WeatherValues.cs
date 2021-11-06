using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    public class WeatherValues
    {
        [JsonPropertyName("coverage")]
        public string Coverage { get; set; }

        [JsonPropertyName("weather")]
        public string Weather { get; set; }

        [JsonPropertyName("intensity")]
        public string Intensity { get; set; }

        [JsonPropertyName("visibility")]
        public QuantitativeValue<int?> Visibility { get; set; }

        [JsonPropertyName("attributes")]
        public List<string> Attributes { get; set; }
    }
}