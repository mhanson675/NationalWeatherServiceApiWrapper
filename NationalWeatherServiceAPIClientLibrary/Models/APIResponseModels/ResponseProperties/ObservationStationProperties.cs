using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties
{
    public class ObservationStationProperties
    {
        [JsonPropertyName("elevation")]
        public Elevation Elevation { get; set; }

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
}
