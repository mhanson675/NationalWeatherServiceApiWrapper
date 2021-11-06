using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace NationalWeatherServiceApiClientLibrary.Tests
{
    public class JsonSerializingTests
    {
        [Fact]
        public async Task Deserialize_GridPointsRawForecastResponse_Success()
        {
            var fileName = "rawforecastresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<GridPointsRawForecastResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
            Assert.NotNull(response.Geometry.Coordinates);
            Assert.Equal("wmoUnit:degC", response.Properties.Temperature.Uom);
            Assert.Equal("2021-11-05T02:00:00+00:00/PT2H", response.Properties.Temperature.Values.First().ValidTime);
            Assert.Equal(10.555555555555555m, response.Properties.Temperature.Values.First().Value);
        }

        [Fact]
        public async Task Deserialize_GridPointsTextualForecastResponse_Success()
        {
            var fileName = "gridpointstextualforecastresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<GridpointsTextualForecastResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Geometry);
            Assert.Equal(5, response.Geometry.Coordinates.First().Count);
            Assert.NotNull(response.Properties.Periods);
            Assert.Equal(62, response.Properties.Periods.First().Temperature);
            Assert.True(response.Properties.Periods.First().IsDaytime);
        }

        [Fact]
        public async Task Deserialize_GridPointsHourlyTextualForecastResponse_Success()
        {
            var fileName = "gridpointsforecasthourlyresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<GridpointsTextualForecastResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Geometry);
            Assert.Equal(5, response.Geometry.Coordinates.First().Count);
            Assert.Equal(156, response.Properties.Periods.Count);
            Assert.Equal(62, response.Properties.Periods.First().Temperature);
            Assert.True(response.Properties.Periods.First().IsDaytime);
        }

        [Fact]
        public async void Deserialize_StationsResponse_From_PointsStations_Success()
        {
            var fileName = "stationsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Stations);
            Assert.Equal("KSSF", response.Stations.First().Properties.StationIdentifier);
            Assert.Equal("KCVB", response.Stations.Skip(1).First().Properties.StationIdentifier);
        }

        [Fact]
        public async Task Deserialize_StationObservationsResponse_Success()
        {
            var fileName = "stationobservationsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationObservationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.Equal(455, response.Observations.Count());
            Assert.Equal(-79.5, response.Observations.First().Geometry.Value[0]);
            Assert.Equal(0.80000000000000004, response.Observations.First().Properties.Temperature.Value);
            Assert.Equal("Clear", response.Observations.First().Properties.TextDescription);
        }

        [Fact]
        public async void Deserialize_StationObservationResponse_From_Latest_Success()
        {
            var fileName = "stationobservationslatestresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationObservationResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
            Assert.NotNull(response.Properties.CloudLayers);
            Assert.NotNull(response.Properties.Temperature.Value);
            Assert.Equal(6.5, response.Properties.Temperature.Value);
        }

        [Fact]
        public async void Deserialize_StationObservationResponse_From_Time_Success()
        {
            var fileName = "stationobservationsresponsetime.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationObservationResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
            Assert.NotNull(response.Properties.CloudLayers);
            Assert.NotNull(response.Properties.Temperature.Value);
            Assert.Equal(0.80000000000000004, response.Properties.Temperature.Value);
            Assert.Equal("Clear", response.Properties.TextDescription);
        }

        [Fact]
        public async void Deserialize_StationsResponse_From_StateStations_Success()
        {
            var fileName = "statestationsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Stations);
            Assert.Equal("LBJT2", response.Stations.First().Properties.StationIdentifier);
            Assert.Equal("BZRT2", response.Stations.Skip(1).First().Properties.StationIdentifier);
        }

        [Fact]
        public async Task Deserialize_PointsResponse_Success()
        {
            var fileName = "pointsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<PointsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
            Assert.Equal("EWX", response.Properties.GridId);
            Assert.Equal(120, response.Properties.GridX);
            Assert.Equal(52, response.Properties.GridY);
        }
    }
}