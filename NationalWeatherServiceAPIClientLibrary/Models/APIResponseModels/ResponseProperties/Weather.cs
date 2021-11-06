using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    public class Weather
    {
        [JsonPropertyName("values")]
        public List<DataEntryValue<List<WeatherValues>>> Values { get; set; }
    }
}