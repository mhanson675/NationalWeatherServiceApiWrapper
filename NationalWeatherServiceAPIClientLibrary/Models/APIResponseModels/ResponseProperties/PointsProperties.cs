using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases;
using System.Text.Json.Serialization;

namespace NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties
{
    /// <summary>
    /// A class representing the properties for the data returned by the Weather.gov Api '/points/{point}' endpoint
    /// </summary>
#pragma warning disable CS1591

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

#pragma warning restore CS1591
}