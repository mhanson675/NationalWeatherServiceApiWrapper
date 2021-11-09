using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'gridpoints/{wfo}/{grix},{gridy}/forecast' endpoint
    /// </summary>
    public class GridpointsTextualForecastResponse
    {
#pragma warning disable CS1591

        [JsonPropertyName("properties")]
        public GridPointsTextualForecastProperties Properties { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPolygon Geometry { get; set; }

#pragma warning restore CS1591
    }
}