﻿using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models
{

    public class ObservationStation
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public ObservationStationProperties Properties { get; set; }
    }

}