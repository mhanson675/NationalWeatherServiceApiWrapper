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
    
    public class GeoJsonCoordinate
    {
        public double[] Value { get; set; } = new double[2];
    }
    public class GeoPoint
    {
        [JsonPropertyName("coordinates")]
        public double[] Value { get; set; } = new double[2];
        //public GeoJsonCoordinate Coordinates { get; set; }
    }

    public class GeoPolygon
    {
        [JsonPropertyName("coordinates")]
        public List<List<List<double>>> Coordinates { get; set; }
        //public GeoJsonCoordinate[] Coordinates { get; set; } = new GeoJsonCoordinate[2];
    }

    public class GeoLineString
    {
        [JsonPropertyName("coordinates")]
        public List<double[]> Coordinates { get; set; }
        //public List<GeoJsonCoordinate> Coordinates { get; set; } = new List<GeoJsonCoordinate>();
    }
}