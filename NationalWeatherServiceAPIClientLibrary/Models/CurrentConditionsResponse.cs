using System;
using System.Text.Json.Serialization;
using NationalWeatherServiceAPIClientLibrary.Extensions;

namespace NationalWeatherServiceAPIClientLibrary.Models
{
    public enum MeasurementUnits { Metric, Imperial }

    /// <summary>
    /// Current weather conditions
    /// </summary>
    public class CurrentConditionsResponse
    {
        [JsonPropertyName("timestamp")]
        public DateTime ObservationDate { get; set; }

        /// <summary>
        /// The station that provided the conditions.
        /// </summary>
        public WeatherStation Station { get; set; }

        public MeasurementUnits UnitOfMeasurement { get; set; }

        public string TextDescription { get; set; }

        public decimal? Temperature { get; set; }

        public decimal? DewPoint { get; set; }

        public decimal? WindDirection { get; set; }

        public decimal? WindSpeed { get; set; }

        public decimal? WindGust { get; set; }

        public decimal? BarometricPressure { get; set; }

        public decimal? SeaLevelPressure { get; set; }

        public decimal? Visibility { get; set; }

        public decimal? RelativeHumidity { get; set; }

        public decimal? WindChill { get; set; }

        public decimal? HeatIndex { get; set; }

        public void ConvertUnits(MeasurementUnits desiredUnits)
        {
            if (desiredUnits != UnitOfMeasurement)
            {
                ConvertAllPropertiesUnits();
            }
        }

        private void ConvertAllPropertiesUnits()
        {
            if (UnitOfMeasurement == MeasurementUnits.Metric)
            {
                Temperature = Temperature?.ConvertCelsiusToFahrenheit() ?? Temperature;
                DewPoint = DewPoint?.ConvertCelsiusToFahrenheit() ?? DewPoint;
                WindChill = WindChill?.ConvertCelsiusToFahrenheit() ?? WindChill;
                HeatIndex = HeatIndex?.ConvertCelsiusToFahrenheit() ?? HeatIndex;

                WindSpeed = WindSpeed?.ConvertKilometersPerHourToMilesPerHour() ?? WindSpeed;
                WindGust = WindGust?.ConvertKilometersPerHourToMilesPerHour() ?? WindChill;
            }
            else
            {
                Temperature = Temperature?.ConvertFahrenheitToCelcius() ?? Temperature;
                DewPoint = DewPoint?.ConvertFahrenheitToCelcius() ?? DewPoint;
                WindChill = WindChill?.ConvertFahrenheitToCelcius() ?? WindChill;
                HeatIndex = HeatIndex?.ConvertFahrenheitToCelcius() ?? HeatIndex;

                WindSpeed = WindSpeed?.ConvertMilesPerHourToKilometersPerHour() ?? WindSpeed;
                WindGust = WindGust?.ConvertMilesPerHourToKilometersPerHour() ?? WindChill;
            }
        }
    }
}