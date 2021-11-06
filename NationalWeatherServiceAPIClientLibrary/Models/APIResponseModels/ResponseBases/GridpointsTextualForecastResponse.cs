using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases
{
    public class GridpointsTextualForecastResponse
    {
        [JsonPropertyName("properties")]
        public GridPointsTextualForecastProperties Properties { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPolygon Geometry { get; set; }
    }
}