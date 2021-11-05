using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.QuantitativeValues
{
    public class MaxTemperatureLast24HoursQV
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }
}