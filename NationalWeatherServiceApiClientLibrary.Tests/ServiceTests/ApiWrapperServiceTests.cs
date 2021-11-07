using Moq;
using Moq.Protected;
using NationalWeatherServiceAPI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace NationalWeatherServiceApiClientLibrary.Tests.ServiceTests
{
    public class ApiWrapperServiceTests
    {
        [Fact]
        public async Task InvalidJsonData_Throws_JsonExeption()
        {
            var handler = new Mock<HttpMessageHandler>();
            handler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("testing")
                });

            var underTest = new WeatherDotGovApiWrapper(new NWSHttpClient(handler.Object));
            await Assert.ThrowsAsync<JsonException>(() => underTest.GetRawNumericalForecastForGridArea("EWX", 112, 52));
        }

        [Theory]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.Forbidden)]
        public async Task NonSuccessResponseCode_Throws_HttpRequestException(HttpStatusCode statusCode)
        {
            var handler = new Mock<HttpMessageHandler>();
            handler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = statusCode,
                    Content = new StringContent("testing")
                });

            var underTest = new WeatherDotGovApiWrapper(new NWSHttpClient(handler.Object));

            var ex = await Assert.ThrowsAsync<HttpRequestException>(() => underTest.GetRawNumericalForecastForGridArea("EWX", 112, 52));
            var statusCodeNumber = (int)statusCode;
            Assert.Contains(statusCodeNumber.ToString(), ex.Message);
        }

        [Fact]
        public void InvalidContent_Throws_NotSupportedException()
        {
            //TODO: Figure out how to make System.Text.Json throw a NotSupportedException
        }
    }
}