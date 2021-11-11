using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases;
using System;
using System.Threading.Tasks;

namespace NationalWeatherServiceAPI
{
    /// <summary>
    /// Interface for WeatherDotGovApiWrapper
    /// </summary>
#pragma warning disable CS1591

    public interface IWeatherDotGovApiWrapper
    {
        Task<StationsResponse> GetAllWeatherStationsForStateAsync(string state);

        Task<PointsResponse> GetGridpointAsync(double lat, double lon);

        Task<GridpointsTextualForecastResponse> GetHourlyTextualForecastForGridArea(string wfo, int gridX, int gridY);

        Task<StationObservationResponse> GetLatestObservationsForStation(string stationId);

        Task<StationObservationResponse> GetObservationsForStation(string stationId);

        Task<StationsResponse> GetObservationStations(double lat, double lon);

        Task<StationsResponse> GetObservationStations(string wfo, int gridX, int gridY);

        Task<GridPointsRawForecastResponse> GetRawNumericalForecastForGridArea(string wfo, int gridX, int gridY);

        Task<StationObservationResponse> GetSpecificObservationForStation(string stationId, string time);

        Task<GridpointsTextualForecastResponse> GetTextualForecastForGridArea(string wfo, int gridX, int gridY);
    }

#pragma warning restore CS1591
}