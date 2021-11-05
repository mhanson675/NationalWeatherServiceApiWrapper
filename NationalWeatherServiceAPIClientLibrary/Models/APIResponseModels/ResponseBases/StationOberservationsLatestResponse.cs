using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases
{
    public class StationObservationsLatestResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public StationsObservationsLatestsProperties Properties { get; set; }
    }
}