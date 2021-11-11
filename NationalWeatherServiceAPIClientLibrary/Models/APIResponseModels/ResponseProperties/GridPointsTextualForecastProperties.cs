using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    /// <summary>
    /// A class representing the forecast properties returned by the Weather.gov Api '/gridpoints/{wfp}/{gridX},{gridY}/forecast' or '/gridpoints/{wfo}/{gridX},{gridY}/forecast/hourly endpoint
    /// </summary>
#pragma warning disable CS1591

    public class GridPointsTextualForecastProperties
    {
        [JsonPropertyName("updated")]
        public DateTime Updated { get; set; }

        [JsonPropertyName("units")]
        public string Units { get; set; }

        [JsonPropertyName("forecastGenerator")]
        public string ForecastGenerator { get; set; }

        [JsonPropertyName("generatedAt")]
        public DateTime GeneratedAt { get; set; }

        [JsonPropertyName("updateTime")]
        public DateTime UpdateTime { get; set; }

        [JsonPropertyName("validTimes")]
        public string ValidTimes { get; set; }

        [JsonPropertyName("elevation")]
        public QuantitativeValue<double?> Elevation { get; set; }

        [JsonPropertyName("periods")]
        public List<TextualForecastPeriod> Periods { get; set; }
    }

#pragma warning restore CS1591
}