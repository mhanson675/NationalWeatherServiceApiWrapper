using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Converters
{
    /// <summary>
    /// Json Converter for converting a Json Polygon Array to a Polygon Type
    /// </summary>
    public class PolygonArrayConverter : JsonConverter<List<List<double[]>>>
    {
#pragma warning disable CS1591

        public override List<List<double[]>> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            return JsonSerializer.Deserialize<List<List<double[]>>>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, List<List<double[]>> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }

#pragma warning restore CS1591
    }
}