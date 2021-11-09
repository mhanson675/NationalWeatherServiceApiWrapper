using NationalWeatherServiceAPIClientLibrary.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// Abstract Class for representing a GeoJson object (Point, Polygon, ect)
    /// </summary>
#pragma warning disable CS1591

    public abstract class Geometry
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

#pragma warning restore CS1591
    /// <summary>
    /// A class representing a GeoJsonPoint
    /// </summary>
#pragma warning disable CS1591

    public class GeoPoint
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        [JsonConverter(typeof(PointArrayConverter))]
        public double[] Coordinates { get; set; } = new double[2];
    }

#pragma warning restore CS1591

    /// <summary>
    /// A class representing a GeoJsonPolygon
    /// </summary>
#pragma warning disable CS1591

    public class GeoPolygon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        [JsonConverter(typeof(PolygonArrayConverter))]
        public List<List<double[]>> Coordinates { get; set; } = new List<List<double[]>>();
    }

#pragma warning restore CS1591
    /// <summary>
    /// A class representing a GeoJsonPoint
    /// </summary>
#pragma warning disable CS1591

    public class GeoLine
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        [JsonConverter(typeof(LineStringArrayConverter))]
        public List<double[]> Coordinates { get; set; } = new List<double[]>();
    }

#pragma warning restore CS1591
}