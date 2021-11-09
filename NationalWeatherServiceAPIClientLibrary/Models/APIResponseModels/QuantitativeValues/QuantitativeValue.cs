using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues
{
    /// <summary>
    /// A generic class representing a Quantitative Value Entry for readings returned by the Weather.gov Api
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuantitativeValue<T>
    {
#pragma warning disable CS1591

        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public T Value { get; set; }

#pragma warning restore CS1591
    }
}