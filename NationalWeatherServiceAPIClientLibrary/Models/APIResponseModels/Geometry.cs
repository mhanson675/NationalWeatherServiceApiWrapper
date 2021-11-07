using NationalWeatherServiceAPIClientLibrary.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    public abstract class Geometry
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class GeoPoint
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        [JsonConverter(typeof(PointArrayConverter))]
        public double[] Coordinates { get; set; } = new double[2];
    }

    public class GeoPolygon
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        [JsonConverter(typeof(PolygonArrayConverter))]
        public List<List<double[]>> Coordinates { get; set; } = new List<List<double[]>>();
    }

    public class GeoLine
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("coordinates")]
        [JsonConverter(typeof(LineStringArrayConverter))]
        public List<double[]> Coordinates { get; set; } = new List<double[]>();
    }
}