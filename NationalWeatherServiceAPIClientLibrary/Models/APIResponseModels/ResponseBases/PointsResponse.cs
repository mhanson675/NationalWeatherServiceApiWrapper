using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'points/{point}' endpoint
    /// </summary>
    public class PointsResponse
    {
#pragma warning disable CS1591

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public PointsProperties Properties { get; set; }

#pragma warning restore CS1591
    }
}