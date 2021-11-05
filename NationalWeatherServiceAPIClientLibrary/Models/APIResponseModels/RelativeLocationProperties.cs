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
        public DistanceQV Distance { get; set; }

        [JsonPropertyName("bearing")]
        public BearingQV Bearing { get; set; }
    }
}