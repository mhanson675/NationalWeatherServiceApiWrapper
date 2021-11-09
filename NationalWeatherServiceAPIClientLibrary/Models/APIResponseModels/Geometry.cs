﻿using NationalWeatherServiceAPIClientLibrary.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    public class Geometry<T>
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        public T Coordinates { get; set; }
    }

#pragma warning restore CS1591
    /// <summary>
    /// A class representing a GeoJsonPoint
    /// </summary>
#pragma warning disable CS1591

    public class GeoPoint
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class GeoPolygon : List<GeoLine>
    {
    }

    public class GeoLine : List<GeoPoint>
    {
    }

#pragma warning restore CS1591
}