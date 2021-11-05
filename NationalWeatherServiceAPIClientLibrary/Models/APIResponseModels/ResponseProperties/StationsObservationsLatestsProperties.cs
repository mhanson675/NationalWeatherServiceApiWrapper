using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.QuantitativeValues;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties
{
    public class StationsObservationsLatestsProperties
    {
        [JsonPropertyName("elevation")]
        public Elevation Elevation { get; set; }

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
        public WindDirectionQV WindDirection { get; set; }

        [JsonPropertyName("windSpeed")]
        public WindSpeedQV WindSpeed { get; set; }

        [JsonPropertyName("windGust")]
        public WindGustQV WindGust { get; set; }

        [JsonPropertyName("barometricPressure")]
        public BarometricPressureQV BarometricPressure { get; set; }

        [JsonPropertyName("seaLevelPressure")]
        public SeaLevelPressureQV SeaLevelPressure { get; set; }

        [JsonPropertyName("visibility")]
        public VisibilityQV Visibility { get; set; }

        [JsonPropertyName("maxTemperatureLast24Hours")]
        public MaxTemperatureLast24HoursQV MaxTemperatureLast24Hours { get; set; }

        [JsonPropertyName("minTemperatureLast24Hours")]
        public MinTemperatureLast24HoursQV MinTemperatureLast24Hours { get; set; }

        [JsonPropertyName("precipitationLastHour")]
        public PrecipitationLastHourQV PrecipitationLastHour { get; set; }

        [JsonPropertyName("precipitationLast3Hours")]
        public PrecipitationLast3HoursQV PrecipitationLast3Hours { get; set; }

        [JsonPropertyName("precipitationLast6Hours")]
        public PrecipitationLast6HoursQV PrecipitationLast6Hours { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public RelativeHumidityQV RelativeHumidity { get; set; }

        [JsonPropertyName("windChill")]
        public WindChillQV WindChill { get; set; }

        [JsonPropertyName("heatIndex")]
        public HeatIndexQV HeatIndex { get; set; }

        [JsonPropertyName("cloudLayers")]
        public List<CloudLayer> CloudLayers { get; set; }
    }
}