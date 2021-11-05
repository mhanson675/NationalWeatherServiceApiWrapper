﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class GridpointsForecastResponse
    {
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class Period
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("isDaytime")]
        public bool IsDaytime { get; set; }

        [JsonPropertyName("temperature")]
        public int Temperature { get; set; }

        [JsonPropertyName("temperatureUnit")]
        public string TemperatureUnit { get; set; }

        [JsonPropertyName("temperatureTrend")]
        public object TemperatureTrend { get; set; }

        [JsonPropertyName("windSpeed")]
        public string WindSpeed { get; set; }

        [JsonPropertyName("windDirection")]
        public string WindDirection { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("shortForecast")]
        public string ShortForecast { get; set; }

        [JsonPropertyName("detailedForecast")]
        public string DetailedForecast { get; set; }
    }

    public class Properties
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