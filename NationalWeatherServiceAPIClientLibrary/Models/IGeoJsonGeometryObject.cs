using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public interface IGeoJsonGeometryObject 
    {
        GJGeometryTypes Type { get; }
    }
}
