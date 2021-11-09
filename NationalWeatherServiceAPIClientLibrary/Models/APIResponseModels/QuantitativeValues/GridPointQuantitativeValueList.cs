using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues
{
    /// <summary>
    /// A generic class representing a Quantitative Value List of data returned by the Weather.gov Api
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GridPointQuantitativeValueList<T>
    {
#pragma warning disable CS1591

        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<T>> Values { get; set; }

#pragma warning restore CS1591
    }

    /// <summary>
    /// A generic class representing a Value Entry for readings returned by the Weather.gov Api
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataEntryValue<T>
    {
#pragma warning disable CS1591

        [JsonPropertyName("validTime")]
        public string ValidTime { get; set; }

        [JsonPropertyName("value")]
        public T Value { get; set; }

#pragma warning restore CS1591
    }
}