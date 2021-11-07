using NationalWeatherServiceAPI.Models.APIResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Converters
{
    //TODO: USE OR DELETE
    public class GeometryConverter : JsonConverter<Geometry>
    {
        private enum TypeDiscriminator
        { Point, Polygon, LineString }

        public override bool CanConvert(Type typeToConvert) => typeof(Geometry).IsAssignableFrom(typeToConvert);

        public override Geometry Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            string propertyName = reader.GetString();
            if (propertyName != "type")
            {
                throw new JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException();
            }

            //Geometry geometry = reader.GetString() switch
            //{
            //    "Point" => new GeoPoint(),
            //    "Polygon" => new GeoPolygon(),
            //    "LineString" => new GeoLine(),
            //    _ => throw new JsonException()
            //};

            var value = reader.Read();
            if (reader.TokenType != JsonTokenType.StartArray)
            {
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, Geometry value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}