using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.QuantitativeValues;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class CloudLayer
    {
        [JsonPropertyName("base")]
        public QuantitativeValue<int?> Base { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }
    }


}