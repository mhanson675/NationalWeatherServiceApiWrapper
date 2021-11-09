using System;
using System.Collections.Generic;
using System.Text;

namespace NationalWeatherServiceAPI.Models
{
    public enum GJGeometryTypes
    {
        Point = GeoJsonTypes.Point,
        MultiPoint = GeoJsonTypes.MultiPoint,
        LineString = GeoJsonTypes.LineString,
        MultiLineString = GeoJsonTypes.MultiLineString,
        Polygon = GeoJsonTypes.Polygon,
        MultiPolygon = GeoJsonTypes.MultiPolygon,
        GeometryCollection,
        Feature,
        FeatureCollection

    }

}
