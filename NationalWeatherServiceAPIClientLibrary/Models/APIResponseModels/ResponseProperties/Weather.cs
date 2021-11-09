using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    /// <summary>
    /// A class representing a Weather property returned by the Weather.gov Api
    /// </summary>
#pragma warning disable CS1591

    public class Weather
    {
        [JsonPropertyName("values")]
        public List<DataEntryValue<List<WeatherValues>>> Values { get; set; }
    }

#pragma warning restore CS1591
}