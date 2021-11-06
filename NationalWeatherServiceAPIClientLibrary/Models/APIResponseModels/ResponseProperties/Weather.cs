using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.QuantitativeValues;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties
{
    public class Weather
    {
        [JsonPropertyName("values")]
        public List<DataEntryValue<List<WeatherValues>>> Values { get; set; }
    }
}