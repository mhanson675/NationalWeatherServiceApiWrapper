using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseBases;
using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels.ResponseProperties;
using System;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace NationalWeatherServiceApiClientLibrary.Tests
{
    public class JsonSerializingTests
    {
        [Fact]
        public async Task DeserializeGridPointsRawForecastResponse_Success()
        {
            var fileName = "rawforecastresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<GridPointsRawForecastResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
        }
        [Fact]
        public async Task DeserializePointsResponse_Success()
        {
            var fileName = "pointsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<PointsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
        }

        [Fact]
        public async void DeserializeStations_From_StateStations_Success()
        {
            var fileName = "statestationsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Stations);
        }

        [Fact]
        public async void DeserializeStations_From_PointsStations_Success()
        {
            var fileName = "stationsresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Stations);
        }

        [Fact]
        public async void DeserializeStationObservationLatestResponse_Success()
        {
            var fileName = "stationobservationslatestresponse.json";
            var filePath = Path.Combine("JsonResponseFiles", fileName);
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationObservationsLatestResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
            Assert.NotNull(response.Properties.CloudLayers);
            Assert.NotNull(response.Properties.Temperature.Value);
            Assert.Equal(6.5, response.Properties.Temperature.Value);
        }
    }
}