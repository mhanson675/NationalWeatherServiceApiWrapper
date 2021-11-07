using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace NationalWeatherServiceAPI
{
    /// <summary>
    /// An HttpClient wrapper to setup the base url and user-agent header for use with the National Weather Service API (api.weather.gov)
    /// </summary>
    /// <seealso cref="System.Net.Http.HttpClient" />
    public class NWSHttpClient : HttpClient
    {
        private const string userAgent = "NWS Weather API Wrapper Library for .Net";
        private const string baseAddress = "https://api.weather.gov";

        public NWSHttpClient()
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
        }

        public NWSHttpClient(string userAgentValue)
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.UserAgent.TryParseAdd(userAgentValue);
        }

        public NWSHttpClient(HttpMessageHandler handler) : base(handler)
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
        }
    }
}