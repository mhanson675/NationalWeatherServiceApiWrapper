using NationalWeatherServiceAPI.Models.APIResponseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public class Feature
    {
        public string Id { get; set; }
        public GeoJsonTypes Type { get; set; }
        public object Geometry { get; set; }
        public object Properties { get; set; }
    }
}
