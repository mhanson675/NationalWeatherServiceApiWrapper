using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// A class representing the properties for a Relative Location returned by the Weather.gov
    /// </summary>
    public class RelativeLocationProperties
    {
#pragma warning disable CS1591

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("distance")]
        public QuantitativeValue<double?> Distance { get; set; }

        [JsonPropertyName("bearing")]
        public QuantitativeValue<int?> Bearing { get; set; }

#pragma warning restore CS1591
    }
}