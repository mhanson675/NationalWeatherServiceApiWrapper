using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties
{
    public class GridPointsForecastProperties
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
        public Elevation Elevation { get; set; }

        [JsonPropertyName("periods")]
        public List<Period> Periods { get; set; }
    }
}