using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases
{
    public class StationsResponse
    {
        [JsonPropertyName("features")]
        public List<ObservationStation> Stations { get; set; }

        [JsonPropertyName("observationStations")]
        public List<string> ObservationStationsUrls { get; set; }
    }
}