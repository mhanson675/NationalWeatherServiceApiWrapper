using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    /// <summary>
    /// A class representing the values for a Weather property returned by the Weather.gov Api
    /// </summary>
    public class WeatherValues
    {
#pragma warning disable CS1591

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

#pragma warning restore CS1591
    }
}