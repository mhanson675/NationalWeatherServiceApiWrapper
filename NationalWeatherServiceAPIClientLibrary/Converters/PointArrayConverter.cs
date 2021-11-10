using NationalWeatherServiceAPI.Models.APIResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Converters
{
    /// <summary>
    /// JSon Converter for converting a Point Array to a Geopoint
    /// </summary>
#pragma warning disable CS1591

    public class PointArrayConverter : JsonConverter<GeoPoint>
    {
        public override GeoPoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException();
            }

            GeoPoint point = new GeoPoint();

            point.Longitude = reader.GetDouble();

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException();
            }

            point.Latitude = reader.GetDouble();

            reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException();
            }

            return point;
        }

        public override void Write(Utf8JsonWriter writer, GeoPoint value, JsonSerializerOptions options)
        {
            double[] pointArray = new double[] { value.Longitude, value.Latitude };

            JsonSerializer.Serialize(writer, pointArray, pointArray.GetType(), options);
        }

#pragma warning restore CS1591
    }
}