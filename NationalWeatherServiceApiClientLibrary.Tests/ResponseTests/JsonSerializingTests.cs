using NationalWeatherServiceAPI.Models.APIResponseModels;
using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseBases;
using NationalWeatherServiceAPI.Models.APIResponseModels.ResponseProperties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

#pragma warning disable CS1591, CS1998

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
            //Assert.Equal(5, response.Geometry.Coordinates.Count());
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
            Assert.Equal(-79.5, response.Observations.First().Geometry.Coordinates.Longitude);
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

        [Fact]
        public void Serialize_GeoJsonPoint_Success()
        {
            string json = "{\"type\":\"Point\",\"coordinates\":[-98.64681249,29.398185]}";
            var point = new Geometry<GeoPoint> { Type = "Point", Coordinates = new GeoPoint { Longitude = -98.64681249, Latitude = 29.398185 } };
            var serialized = JsonSerializer.Serialize(point);

            Assert.Equal(json, serialized);
        }

        [Fact]
        public void Deserialize_GeoJsonPoint_Success()
        {
            string json = "{\"type\":\"Point\",\"coordinates\":[-98.64681249,29.398185]}";
            var point = JsonSerializer.Deserialize<Geometry<GeoPoint>>(json);

            Assert.Equal("Point", point.Type);
            Assert.Equal(-98.64681249, point.Coordinates.Longitude);
            Assert.Equal(29.398185, point.Coordinates.Latitude);
        }

        [Fact]
        public void Serialize_GeoJsonLine_Success()
        {
            string json = "{\"type\":\"LineString\",\"coordinates\":[[-98.64681249,29.398185],[-98.619989,29.376031]]}";
            var line = new Geometry<GeoLine>
            {
                Type = "LineString",
                Coordinates = new GeoLine
            {
                new GeoPoint { Longitude = -98.64681249, Latitude = 29.398185 },
                new GeoPoint { Longitude = -98.619989, Latitude = 29.376031 }
            }
            };
            var serialized = JsonSerializer.Serialize(line);

            Assert.Equal(json, serialized);
        }

        [Fact]
        public void Deserialize_GeoJsonLine_Success()
        {
            string json = "{\"type\":\"LineString\",\"coordinates\":[[-98.64681249,29.398185],[-98.619989,29.376031]]}";
            var line = JsonSerializer.Deserialize<Geometry<GeoLine>>(json);

            Assert.Equal("LineString", line.Type);
            Assert.Equal(-98.64681249, line.Coordinates.First().Longitude);
            Assert.Equal(29.398185, line.Coordinates.First().Latitude);
        }

        [Fact]
        public void Serialize_GeoPoly_Success()
        {
            string json = "{\"type\":\"Polygon\",\"coordinates\":" +
                "[" +
                "[" +
                "[-98.646812,29.39818]," +
                "[-98.646109,29.37542]," +
                "[-98.619989,29.37603]," +
                "[-98.620687,29.39879]," +
                "[-98.646812,29.39818]" +
                "]]}";
            var polygon = new Geometry<GeoPolygon>
            {
                Type = "Polygon",
                Coordinates = new GeoPolygon
                {
                    new GeoLine
                    {
                        new GeoPoint {Longitude = -98.646812, Latitude = 29.39818},
                        new GeoPoint {Longitude = -98.646109, Latitude = 29.37542},
                        new GeoPoint {Longitude = -98.619989, Latitude = 29.37603},
                        new GeoPoint {Longitude = -98.620687, Latitude = 29.39879},
                        new GeoPoint {Longitude = -98.646812, Latitude = 29.39818}
                    }
                }
            };
            var serialized = JsonSerializer.Serialize(polygon);

            Assert.Equal(json, serialized);
        }

        [Fact]
        public void Deserialize_GeoPoly_Success()
        {
            string json = "{\"type\":\"Polygon\",\"coordinates\":[" +
                            "[[-98.646812,29.39818],[-98.646109,29.37542],[-98.619989,29.37603],[-98.620687,29.39879],[-98.646812,29.39818]]" +
                            "]}";
            var polygon = JsonSerializer.Deserialize<Geometry<GeoPolygon>>(json);

            Assert.Equal("Polygon", polygon.Type);
            Assert.Equal(-98.646812, polygon.Coordinates.First().First().Longitude);
            Assert.Equal(29.39818, polygon.Coordinates.First().First().Latitude);
        }

        [Fact]
        public void Serialize_GeoPoly_With_Hole_Success()
        {
            string json = "{\"type\":\"Polygon\",\"coordinates\":[" +
                            "[[-98.646812,29.39818],[-98.646109,29.37542],[-98.619989,29.37603]]," +
                            "[[-98.620687,29.39879],[-98.646812,29.39818]]" +
                            "]}";
            var polygon = new Geometry<GeoPolygon>
            {
                Type = "Polygon",
                Coordinates = new GeoPolygon
                {
                    new GeoLine
                    {
                        new GeoPoint {Longitude = -98.646812, Latitude = 29.39818},
                        new GeoPoint {Longitude = -98.646109, Latitude = 29.37542},
                        new GeoPoint {Longitude = -98.619989, Latitude = 29.37603}
                    },
                    new GeoLine
                    {
                        new GeoPoint {Longitude = -98.620687, Latitude = 29.39879},
                        new GeoPoint {Longitude = -98.646812, Latitude = 29.39818}
                    }
                }
            };
            var serialized = JsonSerializer.Serialize(polygon);

            Assert.Equal(json, serialized);
        }

        [Fact]
        public void Deserialize_GeoPoly_With_Hole_Success()
        {
            string json = "{\"type\":\"Polygon\",\"coordinates\":[" +
                            "[[-98.646812,29.39818],[-98.646109,29.37542],[-98.619989,29.37603]]," +
                            "[[-98.620687,29.39879],[-98.646812,29.39818]]" +
                            "]}";
            var polygon = JsonSerializer.Deserialize<Geometry<GeoPolygon>>(json);

            Assert.Equal("Polygon", polygon.Type);
            Assert.Equal(2, polygon.Coordinates.Count());
            Assert.Equal(-98.646812, polygon.Coordinates.First().First().Longitude);
            Assert.Equal(29.39818, polygon.Coordinates.First().First().Latitude);
        }
    }
}

#pragma warning restore CS1591, CS1998