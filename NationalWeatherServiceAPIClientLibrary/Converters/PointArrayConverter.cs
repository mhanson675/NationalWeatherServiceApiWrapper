using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Converters
{
    /// <summary>
    /// Json Converter for converting a GeoJsonPoint Object to and from a Point Object
    /// </summary>
    public class PointArrayConverter : JsonConverter<double[]>
    {
#pragma warning disable CS1591

        public override double[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            return JsonSerializer.Deserialize<double[]>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, double[] value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }

#pragma warning restore CS1591
    }
}