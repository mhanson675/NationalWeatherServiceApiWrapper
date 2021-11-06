using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.QuantitativeValues;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class RelativeLocationProperties
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("distance")]
        public QuantitativeValue<double?> Distance { get; set; }

        [JsonPropertyName("bearing")]
        public QuantitativeValue<int?> Bearing { get; set; }
    }
}