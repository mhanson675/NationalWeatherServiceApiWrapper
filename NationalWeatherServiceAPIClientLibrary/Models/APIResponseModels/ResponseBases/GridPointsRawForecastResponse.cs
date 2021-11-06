﻿using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases
{
    public class GridPointsRawForecastResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPolygon Geometry { get; set; }

        [JsonPropertyName("properties")]
        public GridPointRawForecastProperties Properties { get; set; }
    }
}