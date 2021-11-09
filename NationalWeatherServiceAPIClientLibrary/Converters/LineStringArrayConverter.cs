using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Converters
{
    /// <summary>
    /// Json converter for converting a GeoJsonLineString to and form a LineString type
    /// </summary>
    public class LineStringArrayConverter : JsonConverter<List<double[]>>
    {
#pragma warning disable CS1591

        public override List<double[]> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException();
            }

            return JsonSerializer.Deserialize<List<double[]>>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, List<double[]> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }

#pragma warning restore CS1591
    }
}