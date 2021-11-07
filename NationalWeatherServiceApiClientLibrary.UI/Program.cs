﻿using NationalWeatherServiceAPI;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NationalWeatherServiceApiClientLibrary.UI
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var api = new WeatherDotGovApiWrapper(new NWSHttpClient());
            var testRawResponse = await api.GetRawNumericalForecastForGridArea("EWX", 116, 58);

            Console.WriteLine($"ID: {testRawResponse.Id}");
            Console.WriteLine($"{testRawResponse.Properties.Temperature.Values.First().Value}");

            foreach (var property in testRawResponse.Properties.GetType().GetProperties())
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(testRawResponse.Properties, null)}");
            }
        }
    }
}