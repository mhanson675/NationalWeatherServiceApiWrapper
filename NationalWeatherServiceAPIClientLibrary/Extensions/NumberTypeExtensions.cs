namespace NationalWeatherServiceAPIClientLibrary.Extensions
{
    /// <summary>
    /// A utilities class for easy access to conversion utilities
    /// </summary>
    public static class NumberTypeExtensions
    {
        public static decimal ConvertCelsiusToFahrenheit(this decimal celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public static decimal ConvertMetersPerSecondToMilesPerHour(this decimal speed)
        {
            return speed * 2.23694m;
        }

        public static decimal ConvertKilometersPerHourToMilesPerHour(this decimal speed)
        {
            return speed / 1.609m;
        }

        public static decimal ConvertFahrenheitToCelcius(this decimal fahrenheit)
        {
            return (fahrenheit - 32) / (5 / 9);
        }

        public static decimal ConvertMilesPerHourToKilometersPerHour(this decimal speed)
        {
            return speed * 1.609m;
        }

        public static decimal ConvertMilesPerHourToMetersPerSecond(this decimal speed)
        {
            return speed / 2.23694m;
        }
    }
}