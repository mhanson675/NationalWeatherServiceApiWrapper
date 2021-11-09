using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// A class representing the MetarPhenomenon data return by the Weather.gov Api
    /// </summary>
    public class MetarPhenomenon
    {
#pragma warning disable CS1591

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

#pragma warning restore CS1591
    }
}