using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// An object represeting the Cloud layer data provided by the Weather.gov Api
    /// </summary>
    public class CloudLayer
    {
#pragma warning disable CS1591

        [JsonPropertyName("base")]
        public QuantitativeValue<int?> Base { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

#pragma warning restore CS1591
    }
}