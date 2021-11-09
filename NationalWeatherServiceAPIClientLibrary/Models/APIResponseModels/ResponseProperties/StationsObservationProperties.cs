using NationalWeatherServiceAPI.Models.APIResponseModels.QuantitativeValues;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    /// <summary>
    /// A class representing the forecast properties returned by the Weather.gov Api '/stations/{stationId}/observations/latest' or '/stations/{stationId/observations/{time} endpoint
    /// </summary>
#pragma warning disable CS1591

    public class StationsObservationProperties
    {
        [JsonPropertyName("elevation")]
        public QuantitativeValue<decimal?> Elevation { get; set; }

        [JsonPropertyName("station")]
        public string Station { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("textDescription")]
        public string TextDescription { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("presentWeather")]
        public List<MetarPhenomenon> PresentWeather { get; set; }

        [JsonPropertyName("temperature")]
        public QuantitativeValue<double?> Temperature { get; set; }

        [JsonPropertyName("dewpoint")]
        public QuantitativeValue<double?> Dewpoint { get; set; }

        [JsonPropertyName("windDirection")]
        public QuantitativeValue<int?> WindDirection { get; set; }

        [JsonPropertyName("windSpeed")]
        public QuantitativeValue<double?> WindSpeed { get; set; }

        [JsonPropertyName("windGust")]
        public QuantitativeValue<double?> WindGust { get; set; }

        [JsonPropertyName("barometricPressure")]
        public QuantitativeValue<int?> BarometricPressure { get; set; }

        [JsonPropertyName("seaLevelPressure")]
        public QuantitativeValue<int?> SeaLevelPressure { get; set; }

        [JsonPropertyName("visibility")]
        public QuantitativeValue<int?> Visibility { get; set; }

        [JsonPropertyName("maxTemperatureLast24Hours")]
        public QuantitativeValue<decimal?> MaxTemperatureLast24Hours { get; set; }

        [JsonPropertyName("minTemperatureLast24Hours")]
        public QuantitativeValue<decimal?> MinTemperatureLast24Hours { get; set; }

        [JsonPropertyName("precipitationLastHour")]
        public QuantitativeValue<int?> PrecipitationLastHour { get; set; }

        [JsonPropertyName("precipitationLast3Hours")]
        public QuantitativeValue<int?> PrecipitationLast3Hours { get; set; }

        [JsonPropertyName("precipitationLast6Hours")]
        public QuantitativeValue<int?> PrecipitationLast6Hours { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public QuantitativeValue<double?> RelativeHumidity { get; set; }

        [JsonPropertyName("windChill")]
        public QuantitativeValue<decimal?> WindChill { get; set; }

        [JsonPropertyName("heatIndex")]
        public QuantitativeValue<decimal?> HeatIndex { get; set; }

        [JsonPropertyName("cloudLayers")]
        public List<CloudLayer> CloudLayers { get; set; }
    }

#pragma warning restore CS1591
}