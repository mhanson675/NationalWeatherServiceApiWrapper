using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    public class ObservationStation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry<GeoPoint> Geometry { get; set; }

        [JsonPropertyName("properties")]
        public ObservationStationProperties Properties { get; set; }
    }
}