using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels
{
    public class GridPointsRawForecastResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("geometry")]
        public GeoPolygon Geometry { get; set; }

        [JsonPropertyName("properties")]
        public GridPointRawForecastProperties Properties { get; set; }
    }

    public class DataEntryValue<T>
    {
        [JsonPropertyName("validTime")]
        public string ValidTime { get; set; }

        [JsonPropertyName("value")]
        public T Value { get; set; }
    }

    public class TemperatureList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class DewpointList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class MaxTemperatureList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class MinTemperatureList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class RelativeHumidityList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class ApparentTemperatureList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class HeatIndexList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class WindChillList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class SkyCoverList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class WindDirectionList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class WindSpeedList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class WindGustList
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<decimal?>> Values { get; set; }
    }

    public class WeatherValues
    {
        [JsonPropertyName("coverage")]
        public string Coverage { get; set; }

        [JsonPropertyName("weather")]
        public string Weather { get; set; }

        [JsonPropertyName("intensity")]
        public string Intensity { get; set; }

        [JsonPropertyName("visibility")]
        public Visibility Visibility { get; set; }

        [JsonPropertyName("attributes")]
        public List<string> Attributes { get; set; }
    }

    public class Weather
    {
        [JsonPropertyName("values")]
        public List<DataEntryValue<List<WeatherValues>>> Values { get; set; }
    }

    public class ProbabilityOfPrecipitation
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class QuantitativePrecipitation
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class IceAccumulation
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class SnowfallAmount
    {
        [JsonPropertyName("uom")]
        public string Uom { get; set; }

        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }

    public class SnowLevel
    {
        [JsonPropertyName("values")]
        public List<DataEntryValue<int?>> Values { get; set; }
    }


    public class GridPointRawForecastProperties
    {
        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("updateTime")]
        public DateTime UpdateTime { get; set; }

        [JsonPropertyName("validTimes")]
        public string ValidTimes { get; set; }

        [JsonPropertyName("elevation")]
        public Elevation Elevation { get; set; }

        [JsonPropertyName("forecastOffice")]
        public string ForecastOffice { get; set; }

        [JsonPropertyName("gridId")]
        public string GridId { get; set; }

        [JsonPropertyName("gridX")]
        public string GridX { get; set; }

        [JsonPropertyName("gridY")]
        public string GridY { get; set; }

        [JsonPropertyName("temperature")]
        public TemperatureList Temperature { get; set; }

        [JsonPropertyName("dewpoint")]
        public DewpointList Dewpoint { get; set; }

        [JsonPropertyName("maxTemperature")]
        public MaxTemperatureList MaxTemperature { get; set; }

        [JsonPropertyName("minTemperature")]
        public MinTemperatureList MinTemperature { get; set; }

        [JsonPropertyName("relativeHumidity")]
        public RelativeHumidityList RelativeHumidity { get; set; }

        [JsonPropertyName("apparentTemperature")]
        public ApparentTemperatureList ApparentTemperature { get; set; }

        [JsonPropertyName("heatIndex")]
        public HeatIndexList HeatIndex { get; set; }

        [JsonPropertyName("windChill")]
        public WindChillList WindChill { get; set; }

        [JsonPropertyName("skyCover")]
        public SkyCoverList SkyCover { get; set; }

        [JsonPropertyName("windDirection")]
        public WindDirectionList WindDirection { get; set; }

        [JsonPropertyName("windSpeed")]
        public WindSpeedList WindSpeed { get; set; }

        [JsonPropertyName("windGust")]
        public WindGustList WindGust { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("probabilityOfPrecipitation")]
        public ProbabilityOfPrecipitation ProbabilityOfPrecipitation { get; set; }

        [JsonPropertyName("quantitativePrecipitation")]
        public QuantitativePrecipitation QuantitativePrecipitation { get; set; }

        [JsonPropertyName("iceAccumulation")]
        public IceAccumulation IceAccumulation { get; set; }

        [JsonPropertyName("snowfallAmount")]
        public SnowfallAmount SnowfallAmount { get; set; }

        [JsonPropertyName("snowLevel")]
        public SnowLevel SnowLevel { get; set; }

    }
}
