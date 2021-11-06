using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues
{
    public class GridPointQuantitativeValueList<T>
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<T>> Values { get; set; }
    }

    public class DataEntryValue<T>
    {
        [JsonPropertyName("validTime")]
        public string ValidTime { get; set; }

        [JsonPropertyName("value")]
        public T Value { get; set; }
    }
}