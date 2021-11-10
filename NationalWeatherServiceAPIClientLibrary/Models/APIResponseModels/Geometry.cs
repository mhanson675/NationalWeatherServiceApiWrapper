using NationalWeatherServiceAPIClientLibrary.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// Generic class for representing the various GeoJsonGeometry objects
    /// </summary>
    /// <typeparam name="T"></typeparam>
#pragma warning disable CS1591

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
    public class GeoPoint
#pragma warning disable CS1591
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

#pragma warning restore CS1591

    /// <summary>
    /// A class represeting a GeoPolygon
    /// </summary>
    public class GeoPolygon : List<GeoLine>
    {
    }

    /// <summary>
    /// A class represeting a GeoLine
    /// </summary>
    public class GeoLine : List<GeoPoint>
    {
    }

#pragma warning restore CS1591
}