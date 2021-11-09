using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'stations/{stationId}/observations' endpoint
    /// </summary>
    public class StationObservationsResponse
    {
#pragma warning disable CS1591

        [JsonPropertyName("features")]
        public List<StationObservationResponse> Observations { get; set; }

#pragma warning restore CS1591
    }
}