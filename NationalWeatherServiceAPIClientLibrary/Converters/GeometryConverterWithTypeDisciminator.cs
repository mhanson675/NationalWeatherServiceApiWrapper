using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Converters
{
    //TODO: USE OR DELETE
    public class GeometryConverterWithTypeDisciminator : JsonConverter<Geometry>
    {
        enum TypeDiscriminator
        {
            Point = 1,
            Polygon,
            Line,
        }

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
            
            string type = reader.GetString();

            if (!Enum.TryParse(type, out TypeDiscriminator typeDiscriminator)) throw new JsonException();

            
            //Geometry geometry = typeDiscriminator switch
            //{
            //    TypeDiscriminator.Point => new GeoPoint(),
            //    TypeDiscriminator.Polygon => new GeoPolygon(),
            //    TypeDiscriminator.Line => new GeoLineString(),
            //    _ => throw new JsonException()
            //};

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    //TODO: Fix if using
                    return null;
                    //return geometry;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        default:
                            throw new JsonException();
                    }
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, Geometry value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
