using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPIClientLibrary.Models
{
    /// <summary>
    /// A NWS weather station
    /// </summary>
    public class WeatherStation
    {
        public decimal Latitude => Coordinates[1];
        public decimal Longitude => Coordinates[0];
        public string StationIdentifier { get; set; }
        public string Name { get; set; }
        public decimal Elevation { get; set; }
        public decimal[] Coordinates { get; set; } = new decimal[2];
    }
}