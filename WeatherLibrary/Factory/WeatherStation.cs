using System;
using WeatherLibrary.Core;
using WeatherLibrary.Interfaces;

namespace WeatherLibrary.Factory
{
    /// <summary>
    /// Factory for creating weather display objects.
    /// </summary>
    public static class WeatherStation
    {
        public static IWeatherObserver CreateDisplay(string type)
        {
            return type.ToLower() switch
            {
                "current" => new CurrentConditionsDisplay(),
                "stats" => new StatisticsDisplay(),
                "forecast" => new ForecastDisplay(),
                _ => throw new ArgumentException("Invalid display type.")
            };
        }
    }
}
