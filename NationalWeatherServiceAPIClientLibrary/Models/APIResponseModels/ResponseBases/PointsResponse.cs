using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases
{
    /// <summary>
    /// A class representing the root data returned by the Weather.gov Api 'points/{point}' endpoint
    /// </summary>
    public class PointsResponse
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The string url for the current GridPoint.
        /// </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the geometry.
        /// </summary>
        /// <value>
        /// A <see cref="Geometry{GeoPoint}"></see> object, containing the coordinates for the Point.
        /// </value>
        [JsonPropertyName("geometry")]
        public Geometry<GeoPoint> Geometry { get; set; }

        /// <summary>
        /// Gets or sets the properties.
        /// </summary>
        /// <value>
        /// The <see cref="PointsProperties"/> object containing all the data for the Point.
        /// </value>
        [JsonPropertyName("properties")]
        public PointsProperties Properties { get; set; }
    }
}