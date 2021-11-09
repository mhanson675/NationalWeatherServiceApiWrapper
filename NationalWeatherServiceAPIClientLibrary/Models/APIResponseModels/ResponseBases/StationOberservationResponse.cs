using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'stations/{stationId}/observations/latest' or 'stations/{stationId}/observations/{time}' endpoint
    /// </summary>
    public class StationObservationResponse
    {
#pragma warning disable CS1591

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public Geometry<double[]> Geometry { get; set; }

        [JsonPropertyName("properties")]
        public StationsObservationProperties Properties { get; set; }

#pragma warning restore CS1591
    }
}