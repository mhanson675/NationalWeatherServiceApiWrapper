using NationalWeatherServiceAPIClientLibrary.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels
{
    /// <summary>
    /// Generic class for representing the various GeoJsonGeometry objects
    /// <para>
    /// Whose generic type is one of:
    /// <list type="bullet">
    /// <item><see cref="GeoPoint"/></item>
    /// <item><see cref="GeoLine"/></item>
    /// <item><see cref="GeoPolygon"/></item>
    /// </list>
    /// </para>
    /// </summary>
    /// <typeparam name="T">The Geometry Type for this instance</typeparam>

    public class Geometry<T> where T : ICoordinateType
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The string representation of the Type.
        /// </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        /// <value>
        /// The Coordinates List for the given Geometry
        /// </value>
        [JsonPropertyName("coordinates")]
        public T Coordinates { get; set; }
    }

    /// <summary>
    /// A class representing a GeoJsonPoint
    /// </summary>
    ///
    [JsonConverter(typeof(PointArrayConverter))]
    public class GeoPoint : ICoordinateType
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>
        /// The latitude for the Point
        /// </value>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>
        /// The longitude for the Point
        /// </value>
        public double Longitude { get; set; }
    }

    /// <summary>
    /// A class represeting a GeoPolygon
    /// </summary>
    public class GeoPolygon : List<GeoLine>, ICoordinateType
    {
    }

    /// <summary>
    /// A class represeting a GeoLine
    /// </summary>
    public class GeoLine : List<GeoPoint>, ICoordinateType
    {
    }

    /// <summary>
    /// Interface for Coordinate Types
    /// </summary>
    public interface ICoordinateType
    { }
}