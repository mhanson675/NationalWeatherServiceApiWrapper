using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class RelativeLocation
    {
        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public RelativeLocationProperties Properties { get; set; }
    }
}