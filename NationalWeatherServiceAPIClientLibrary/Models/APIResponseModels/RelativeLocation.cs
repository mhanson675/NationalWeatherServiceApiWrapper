﻿using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    public class RelativeLocation
    {
        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public RelativeLocationProperties Properties { get; set; }
    }
}