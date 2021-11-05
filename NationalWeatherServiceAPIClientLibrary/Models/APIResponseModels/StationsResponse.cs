using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ObservationStationProperties
{
    [JsonPropertyName("elevation")]
    public Elevation Elevation { get; set; }

    [JsonPropertyName("stationIdentifier")]
    public string StationIdentifier { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }

    [JsonPropertyName("forecast")]
    public string ForecastUrl { get; set; }

    [JsonPropertyName("county")]
    public string CountyUrl { get; set; }

    [JsonPropertyName("fireWeatherZone")]
    public string FireWeatherZoneUrl { get; set; }
}

public class ObservationStation
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("geometry")]
    public GeoPoint Geometry { get; set; }

    [JsonPropertyName("properties")]
    public ObservationStationProperties Properties { get; set; }
}

public class StationsResponse
{
    [JsonPropertyName("features")]
    public List<ObservationStation> Stations { get; set; }

    [JsonPropertyName("observationStations")]
    public List<string> ObservationStationsUrls { get; set; }
}