using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public interface IPosition
    {
        double? Altitude { get; }
        double Latitude { get; }
        double Longitude { get; }
    }
}
