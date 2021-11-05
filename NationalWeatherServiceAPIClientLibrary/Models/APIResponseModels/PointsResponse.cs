using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class PointsResponse
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("geometry")]
    public GeoPoint Geometry { get; set; }

    [JsonPropertyName("properties")]
    public PointsProperties Properties { get; set; }
}

public class PointsProperties
{
    [JsonPropertyName("@id")]
    public string Id { get; set; }

    [JsonPropertyName("forecastOffice")]
    public string ForecastOfficeUrl { get; set; }

    [JsonPropertyName("gridId")]
    public string GridId { get; set; }

    [JsonPropertyName("gridX")]
    public int GridX { get; set; }

    [JsonPropertyName("gridY")]
    public int GridY { get; set; }

    [JsonPropertyName("forecast")]
    public string ForecastUrl { get; set; }

    [JsonPropertyName("forecastHourly")]
    public string ForecastHourlyUrl { get; set; }

    [JsonPropertyName("forecastGridData")]
    public string GridForecastUrl { get; set; }

    [JsonPropertyName("observationStations")]
    public string ObservationStationsUrl { get; set; }

    [JsonPropertyName("relativeLocation")]
    public RelativeLocation RelativeLocation { get; set; }

    [JsonPropertyName("forecastZone")]
    public string ForecastZoneUrl { get; set; }

    [JsonPropertyName("county")]
    public string CountyZoneUrl { get; set; }

    [JsonPropertyName("fireWeatherZone")]
    public string FireWeatherZoneUrl { get; set; }

    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }

    [JsonPropertyName("radarStation")]
    public string RadarStation { get; set; }
}

public class Distance
{
    [JsonPropertyName("unitCode")]
    public string UnitCode { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

public class Bearing
{
    [JsonPropertyName("unitCode")]
    public string UnitCode { get; set; }

    [JsonPropertyName("value")]
    public int? Value { get; set; }
}

public class RelativeLocation
{
    [JsonPropertyName("geometry")]
    public GeoPoint Geometry { get; set; }

    [JsonPropertyName("properties")]
    public RelativeLocationProperties Properties { get; set; }
}

public class RelativeLocationProperties
{
    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("distance")]
    public Distance Distance { get; set; }

    [JsonPropertyName("bearing")]
    public Bearing Bearing { get; set; }
}