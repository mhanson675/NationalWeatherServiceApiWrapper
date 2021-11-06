using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.QuantitativeValues;
using System;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties
{
    public class GridPointRawForecastProperties
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("updateTime")]
        public DateTime UpdateTime { get; set; }

        [JsonPropertyName("validTimes")]
        public string ValidTimes { get; set; }

        [JsonPropertyName("elevation")]
        public QuantitativeValue<decimal?> Elevation { get; set; }

        [JsonPropertyName("forecastOffice")]
        public string ForecastOffice { get; set; }

        [JsonPropertyName("gridId")]
        public string GridId { get; set; }

        [JsonPropertyName("gridX")]
        public string GridX { get; set; }

        [JsonPropertyName("gridY")]
        public string GridY { get; set; }

        [JsonPropertyName("temperature")]
        public GridPointQuantitativeValueList<decimal?> Temperature { get; set; }

        [JsonPropertyName("dewpoint")]
        public GridPointQuantitativeValueList<decimal?> Dewpoint { get; set; }

        [JsonPropertyName("maxTemperature")]
        public GridPointQuantitativeValueList<decimal?> MaxTemperature { get; set; }

        [JsonPropertyName("minTemperature")]
        public GridPointQuantitativeValueList<decimal?> MinTemperature { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public GridPointQuantitativeValueList<int?> RelativeHumidity { get; set; }

        [JsonPropertyName("apparentTemperature")]
        public GridPointQuantitativeValueList<decimal?> ApparentTemperature { get; set; }

        [JsonPropertyName("heatIndex")]
        public GridPointQuantitativeValueList<decimal?> HeatIndex { get; set; }

        [JsonPropertyName("windChill")]
        public GridPointQuantitativeValueList<decimal?> WindChill { get; set; }

        [JsonPropertyName("skyCover")]
        public GridPointQuantitativeValueList<int?> SkyCover { get; set; }

        [JsonPropertyName("windDirection")]
        public GridPointQuantitativeValueList<int?> WindDirection { get; set; }

        [JsonPropertyName("windSpeed")]
        public GridPointQuantitativeValueList<decimal?> WindSpeed { get; set; }

        [JsonPropertyName("windGust")]
        public GridPointQuantitativeValueList<decimal?> WindGust { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("probabilityOfPrecipitation")]
        public GridPointQuantitativeValueList<int?> ProbabilityOfPrecipitation { get; set; }

        [JsonPropertyName("quantitativePrecipitation")]
        public GridPointQuantitativeValueList<int?> QuantitativePrecipitation { get; set; }

        [JsonPropertyName("iceAccumulation")]
        public GridPointQuantitativeValueList<int?> IceAccumulation { get; set; }

        [JsonPropertyName("snowfallAmount")]
        public GridPointQuantitativeValueList<int?> SnowfallAmount { get; set; }

        [JsonPropertyName("snowLevel")]
        public GridPointQuantitativeValueList<int?> SnowLevel { get; set; }
    }
}