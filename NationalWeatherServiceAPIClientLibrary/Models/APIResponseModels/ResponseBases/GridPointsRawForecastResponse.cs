using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'gridpoints/{wfo}/{grix},{gridy}' endpoint
    /// </summary>
    public class GridPointsRawForecastResponse
    {
#pragma warning disable CS1591

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry<GeoPolygon> Geometry { get; set; }

        [JsonPropertyName("properties")]
        public GridPointRawForecastProperties Properties { get; set; }

#pragma warning restore CS1591
    }
}