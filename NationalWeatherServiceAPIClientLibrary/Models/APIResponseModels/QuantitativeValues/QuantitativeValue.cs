using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues
{
    public class QuantitativeValue<T>
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public T Value { get; set; }
    }
}
