using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// An object representing an Observation Station returned by the Weather.gov API
    /// </summary>
    public class ObservationStation
    {
#pragma warning disable CS1591

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry<GeoPoint> Geometry { get; set; }

        [JsonPropertyName("properties")]
        public ObservationStationProperties Properties { get; set; }

#pragma warning restore CS1591
    }
}