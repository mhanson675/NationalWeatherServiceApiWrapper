using NationalWeatherServiceAPI.Models.APIResponseModels;
using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    /// <summary>
    /// A class representing the properties for an observation station returned by the Weather.gov Api
    /// </summary>
#pragma warning disable CS1591

    public class ObservationStationProperties
    {
        [JsonPropertyName("elevation")]
        public QuantitativeValue<decimal?> Elevation { get; set; }

        [JsonPropertyName("stationIdentifier")]
        public string StationIdentifier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("forecast")]
        public string ForecastUrl { get; set; }

        [JsonPropertyName("county")]
        public string CountyUrl { get; set; }

        [JsonPropertyName("fireWeatherZone")]
        public string FireWeatherZoneUrl { get; set; }
    }

#pragma warning restore CS1591
}