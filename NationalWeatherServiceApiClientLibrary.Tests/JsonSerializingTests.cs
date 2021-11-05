using NationalWeatherServiceAPIClientLibrary.Models.APIResponseModels;
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
        public async Task DeserializePointsResponse_Success()
        {
            var filePath = "pointsresponse.json";
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<PointsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
        }

        [Fact]
        public async void DeserializeStations_From_StateStations_Success()
        {
            var filePath = "statestationsresponse.json";
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Stations);
        }

        [Fact]
        public async void DeserializeStations_From_PointsStations_Success()
        {
            var filePath = "stationsresponse.json";
            using var jsonFile = File.OpenRead(filePath);
            var response = await JsonSerializer.DeserializeAsync<StationsResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Stations);
        }

        [Fact]
        public async void DeserializeStationObservationLatestResponse_Success()
        {
            var filepath = "stationobservationslatestresponse.json";
            using var jsonFile = File.OpenRead(filepath);
            var response = await JsonSerializer.DeserializeAsync<StationObservationsLatestResponse>(jsonFile);

            Assert.NotNull(response);
            Assert.NotNull(response.Properties);
        }
    }
}