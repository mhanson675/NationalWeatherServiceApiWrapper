using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    public class StationObservationResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry<double[]> Geometry { get; set; }

        [JsonPropertyName("properties")]
        public StationsObservationProperties Properties { get; set; }
    }
}