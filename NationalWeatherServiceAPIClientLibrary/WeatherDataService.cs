using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Threading.Tasks;
using NationalWeatherServiceAPIClientLibrary.Models;
using System.Net.Http;
using NationalWeatherServiceAPIClientLibrary.Extensions;
using System.IO;
using GeoCoordinatePortable;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using System.Net.Http.Json;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases;

namespace NationalWeatherServiceAPIClientLibrary
{
    /// <summary>
    /// Gets weather data from the National Weather Service (api.weather.gov)
    /// </summary>
    public class WeatherDataService
    {
        private const string userAgent = "NWS Weather Library for DotNet";

        private readonly HttpClient httpClient;

        public WeatherDataService()
        {
            httpClient = new NWSHttpClient();
        }

        public WeatherDataService(NWSHttpClient client)
        {
            //TODO verify 'user-agent' header and base address
            httpClient = client;
        }

        public async Task<GridPointsRawForecastResponse> GetRawNumericalForecastForGridArea(string wfo, int gridX, int gridY)
        {
            if (!wfo.IsValidWFO())
            {
                throw new ArgumentOutOfRangeException(nameof(wfo), "Must be a valid WeatherForecast Office Grid ID.");
            }

            string endPoint = $"gridpoints/{wfo}/{gridX},{gridY}";
            try
            {
                return await httpClient.GetFromJsonAsync<GridPointsRawForecastResponse>(endPoint);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Gets the current weather conditions for a given observation station.
        /// </summary>
        /// <param name="stationId">The Station Identifier for the station to check.</param>
        /// <returns>A StationObservationsLatestResponse containing current weather data conditions.</returns>
        public async Task<StationObservationsLatestResponse> GetLatestConditionsForStation(string stationId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(stationId))
                {
                    throw new ArgumentNullException(nameof(stationId), "The Station Id cannot be null or empty space.");
                }

                string endPoint = $"stations/{stationId}/observations/latest";

                var latestConditionsResponse = await httpClient.GetFromJsonAsync<StationObservationsLatestResponse>(endPoint);

                return latestConditionsResponse;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// <para>Get all the observation stations for a given location, designated by the latitude and longitude.</para>
        /// <para>Makes a call first to get the Gridpoint associated with the given latitude and longitude.</para>
        /// </summary>
        /// <param name="lat">The latitude of the requested location</param>
        /// <param name="lon">The longitude of the requested locaiton</param>
        /// <returns>A StationsResponse containing all the observation stations for the requested location</returns>
        public async Task<StationsResponse> GetObservationStations(decimal lat, decimal lon)
        {
            try
            {
                var gridPoint = await GetGridpointAsync(lat, lon);
                return await GetObservationStations(gridPoint.Properties.GridId, gridPoint.Properties.GridX, gridPoint.Properties.GridY);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Gets all the observation stations for a given location, designated by the WeatherForecast Office ID and grid points.
        /// </summary>
        /// <param name="wfo">The Weather Forecast Office identifier for the given </param>
        /// <param name="gridX">Forecast grid X coordinate</param>
        /// <param name="gridY">Forecast grid y coordinate</param>
        /// <returns></returns>
        public async Task<StationsResponse> GetObservationStations(string wfo, int gridX, int gridY)
        {
            string gridStationsEndpoint = $"gridpoint/{wfo}/{gridX},{gridY}/stations";

            var stationsResponse = await httpClient.GetFromJsonAsync<StationsResponse>(gridStationsEndpoint);

            return stationsResponse;
        }

        /// <summary>
        /// Gets the information about the given latitude and longitude point.
        /// </summary>
        /// <param name="lat">The latitude of the given point.</param>
        /// <param name="lon">The longitude of the point.</param>
        /// <returns>A PointsResponse containing the metadata for the given latitude and longitude</returns>
        public async Task<PointsResponse> GetGridpointAsync(decimal lat, decimal lon)
        {
            var pointsEndPoint = $"/points/{lat},{lon}";

            var response = await httpClient.GetFromJsonAsync<PointsResponse>(pointsEndPoint);

            return response;
        }

        /// <summary>
        /// Gets all weather stations for a given state from the API
        /// </summary>
        /// <param name="state">The state to get the Weather Stations for</param>
        /// <returns>A list of weather stations for the given state</returns>
        public async Task<StationsResponse> GetAllWeatherStationsForStateAsync(string state)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(state) || state.Length > 2)
                {
                    throw new ArgumentOutOfRangeException(nameof(state), "Must be a 2 character string representing the State (i.e, 'TX', 'VA')");
                }
                return await httpClient.GetFromJsonAsync<StationsResponse>($"stations?state={state}");
            }
            catch (Exception)
            {
                throw;
            }
        }



        // TODO: Move to service, not API wrapper
        /// <summary>
        /// Gets the weather forecast for a given latitude and longitude
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lng">Longitude</param>
        /// <returns>A ForecastResponse containing forecast data for the given latitude and longitude</returns>
        public async Task<ForecastResponse> GetForecastAsync(decimal lat, decimal lng)
        {
            var pointsResponse = await GetGridpointAsync(lat, lng);

            //Get the URL of the observation stations from the response
            string forecastEndpoint = TrimEndpoint(pointsResponse.Properties.GridForecastUrl);

            var forecastResponse = await httpClient.GetAsync(forecastEndpoint);

            forecastResponse.EnsureSuccessStatusCode();

            using Stream stream = await forecastResponse.Content.ReadAsStreamAsync();
            using JsonDocument forecastDocument = await JsonDocument.ParseAsync(stream);

            ForecastResponse forecast = forecastDocument.RootElement.GetProperty("properties").ToObject<ForecastResponse>();

            forecast.Latitude = lat;
            forecast.Longitude = lng;
            forecast.ElevationInMeters = forecastDocument.RootElement.GetProperty("properties").GetProperty("elevation").GetProperty("value").GetInt32();
            forecast.RawData = forecastDocument.RootElement.GetRawText();

            return forecast;
        }

        //TODO: Move to service, not API wrapper
        /// <summary>
        /// Retrieves the closest weather station for the given latitude and longitude coordinates
        /// </summary>
        /// <param name="lat">Latitude to search</param>
        /// <param name="lng">Longitude to search</param>
        /// <param name="state">The United States state to search in</param>
        /// <param name="stationsToExclude">Optional parameter can be used to exclude stations from being returned</param>
        /// <returns>The closest weather station.</returns>
        public async Task<ObservationStation> GetClosestWeatherObservationStationAsync(decimal lat, decimal lng, StateTypes state, List<string> stationsToExclude = null)
        {
            //TODO: Point to Refactored
            var stationsResponse = await GetAllWeatherStationsForStateAsync(state.ToString());

            var stations = stationsResponse.Stations;

            if (stationsToExclude != null && stationsToExclude.Count > 0)
            {
                stations = stations.Where(station => !stationsToExclude.Any(exclude => exclude == station.Properties.StationIdentifier)).ToList();
            }

            ObservationStation closestStation = null;
            double? distanceToClosest = null;

            foreach (var station in stations)
            {
                GeoCoordinate stationCoordinates = new GeoCoordinate(Convert.ToDouble(station.Geometry.Value[1]), Convert.ToDouble(station.Geometry.Value[0]));
                GeoCoordinate userCoordinates = new GeoCoordinate(Convert.ToDouble(lat), Convert.ToDouble(lng));

                var distance = stationCoordinates.GetDistanceTo(userCoordinates);

                if (!distanceToClosest.HasValue || distanceToClosest.Value > distance)
                {
                    distanceToClosest = distance;
                    closestStation = station;
                }
            }

            return closestStation;
        }

        // TODO: Move to service, not API wrapper
        private string TrimEndpoint(string fullUrl)
        {
            string baseAddress = httpClient.BaseAddress.ToString();
            return fullUrl.Replace(baseAddress, "");
        }
    }
}