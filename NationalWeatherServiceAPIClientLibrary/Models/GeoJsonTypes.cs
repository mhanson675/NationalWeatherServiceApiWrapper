using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public enum GeoJsonTypes
    {
        Point,
        MultiPoint,
        LineString,
        MultiLineString,
        Polygon,
        MultiPolygon,
        GeometryCollection,
        Feature,
        FeatureCollection
    }
}
