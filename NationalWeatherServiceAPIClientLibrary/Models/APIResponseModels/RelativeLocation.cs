using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// A class representing a Relative Location returned by the Weather.gov Api
    /// </summary>
    public class RelativeLocation
    {
#pragma warning disable CS1591

        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public RelativeLocationProperties Properties { get; set; }

#pragma warning restore CS1591
    }
}