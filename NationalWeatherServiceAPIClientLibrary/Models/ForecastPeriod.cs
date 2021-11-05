using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPIClientLibrary.Models
{
    /// <summary>
    /// Represents a weather forecast for a defined period of time.
    /// </summary>
    public class ForecastPeriod
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDayTime { get; set; }
        public decimal Temperature { get; set; }
        public string WindSpeed { get; set; }
        public string WindDirection { get; set; }
        public string Icon { get; set; }
        public string ShortForecast { get; set; }
        public string DetailedForecast { get; set; }
    }
}
