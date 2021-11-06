using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class MetarPhenomenon
    {
        [JsonPropertyName("intensity")]
        public string Intensity { get; set; }

        [JsonPropertyName("modifier")]
        public string Modifier { get; set; }

        [JsonPropertyName("weather")]
        public string Weather { get; set; }

        [JsonPropertyName("rawString")]
        public string RawString { get; set; }

        [JsonPropertyName("inVicinity")]
        public bool? InVicinity { get; set; }
    }
}