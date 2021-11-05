using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases
{
    public class PointsResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public PointsProperties Properties { get; set; }
    }

}