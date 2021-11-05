// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class StationObservationsLatestResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPoint Geometry { get; set; }

        [JsonPropertyName("properties")]
        public StationsObservationsLatestsProperties Properties { get; set; }
    }

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
        public List<PresentWeather> PresentWeather { get; set; }

        [JsonPropertyName("temperature")]
        public Temperature Temperature { get; set; }

        [JsonPropertyName("dewpoint")]
        public Dewpoint Dewpoint { get; set; }

        [JsonPropertyName("windDirection")]
        public WindDirection WindDirection { get; set; }

        [JsonPropertyName("windSpeed")]
        public WindSpeed WindSpeed { get; set; }

        [JsonPropertyName("windGust")]
        public WindGust WindGust { get; set; }

        [JsonPropertyName("barometricPressure")]
        public BarometricPressure BarometricPressure { get; set; }

        [JsonPropertyName("seaLevelPressure")]
        public SeaLevelPressure SeaLevelPressure { get; set; }

        [JsonPropertyName("visibility")]
        public Visibility Visibility { get; set; }

        [JsonPropertyName("maxTemperatureLast24Hours")]
        public MaxTemperatureLast24Hours MaxTemperatureLast24Hours { get; set; }

        [JsonPropertyName("minTemperatureLast24Hours")]
        public MinTemperatureLast24Hours MinTemperatureLast24Hours { get; set; }

        [JsonPropertyName("precipitationLastHour")]
        public PrecipitationLastHour PrecipitationLastHour { get; set; }

        [JsonPropertyName("precipitationLast3Hours")]
        public PrecipitationLast3Hours PrecipitationLast3Hours { get; set; }

        [JsonPropertyName("precipitationLast6Hours")]
        public PrecipitationLast6Hours PrecipitationLast6Hours { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public RelativeHumidity RelativeHumidity { get; set; }

        [JsonPropertyName("windChill")]
        public WindChill WindChill { get; set; }

        [JsonPropertyName("heatIndex")]
        public HeatIndex HeatIndex { get; set; }

        [JsonPropertyName("cloudLayers")]
        public List<CloudLayer> CloudLayers { get; set; }
    }

    public class PresentWeather
    {
        [JsonPropertyName("intensity")]
        public string Intensity { get; set; }

        [JsonPropertyName("modifier")]
        public string Modifier { get; set; }

        [JsonPropertyName("weather")]
        public string Weather { get; set; }

        [JsonPropertyName("rawString")]
        public string RawString { get; set; }

        [JsonPropertyName("inVicinity")]
        public bool? InVicinity { get; set; }
    }

    public class Temperature
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class Dewpoint
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class WindDirection
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class WindSpeed
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class WindGust
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class BarometricPressure
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class SeaLevelPressure
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class Visibility
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class MaxTemperatureLast24Hours
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class MinTemperatureLast24Hours
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class PrecipitationLastHour
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class PrecipitationLast3Hours
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class PrecipitationLast6Hours
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }

    public class RelativeHumidity
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class WindChill
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class HeatIndex
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public double? Value { get; set; }
    }

    public class CloudLayer
    {
        [JsonPropertyName("base")]
        public Base Base { get; set; }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }
    }

    public class Base
    {
        [JsonPropertyName("unitCode")]
        public string UnitCode { get; set; }

        [JsonPropertyName("value")]
        public int? Value { get; set; }
    }
}