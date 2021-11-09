using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'gridpoints/{wfo}/{gridX},{gridY}/stations endpoint
    /// </summary>
    public class StationsResponse
    {
#pragma warning disable CS1591

        [JsonPropertyName("features")]
        public List<ObservationStation> Stations { get; set; }

        [JsonPropertyName("observationStations")]
        public List<string> ObservationStationsUrls { get; set; }

#pragma warning restore CS1591
    }
}