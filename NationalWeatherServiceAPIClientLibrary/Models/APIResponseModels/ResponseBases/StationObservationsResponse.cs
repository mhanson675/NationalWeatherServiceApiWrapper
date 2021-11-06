using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    public class StationObservationsResponse
    {
        [JsonPropertyName("features")]
        public List<StationObservationResponse> Observations { get; set; }
    }
}