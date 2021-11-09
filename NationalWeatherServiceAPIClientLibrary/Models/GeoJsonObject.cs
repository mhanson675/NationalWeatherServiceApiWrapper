using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public abstract class GeoJsonObject
    {
        public GeoJsonTypes Type { get; set; }
    }
}
