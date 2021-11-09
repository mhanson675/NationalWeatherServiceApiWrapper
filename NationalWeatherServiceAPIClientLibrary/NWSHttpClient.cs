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

        /// <summary>
        /// Initializes a new instance of the <see cref="NWSHttpClient"/> class using default User-Agent header (NWS Weather API Wrapper Library for .NET)
        /// </summary>
        public NWSHttpClient()
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NWSHttpClient"/> class using the provided string for the User-Agent header values.
        /// </summary>
        /// <param name="userAgentValue">The user agent value.</param>
        public NWSHttpClient(string userAgentValue)
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.UserAgent.TryParseAdd(userAgentValue);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NWSHttpClient"/> class using the provided <see cref="HttpMessageHandler"/>.
        /// </summary>
        /// <param name="handler">The HTTP handler stack to use for sending requests.</param>
        public NWSHttpClient(HttpMessageHandler handler) : base(handler)
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
        }
    }
}