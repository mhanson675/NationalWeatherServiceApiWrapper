using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    public class CloudLayer
    {
        [JsonPropertyName("base")]
        public QuantitativeValue<int?> Base { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }
    }


}