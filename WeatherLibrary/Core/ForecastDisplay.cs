using System;
using WeatherLibrary.Interfaces;

namespace WeatherLibrary.Core
{
    /// <summary>
    /// Observer that provides weather forecast based on pressure changes.
    /// </summary>
    public class ForecastDisplay : IWeatherObserver, IDisplay
    {
        private float lastPressure = 1013;
        private float currentPressure = 1013;

        public void Update(float temp, float hum, float pres)
        {
            lastPressure = currentPressure;
            currentPressure = pres;
            Display();
        }

        public void Display()
        {
            string forecast;

            if (currentPressure > lastPressure)
            {
                forecast = "Forecast: Improving weather!";
            }
            else if (currentPressure < lastPressure)
            {
                forecast = "Forecast: Cooler, rainy weather.";
            }
            else
            {
                forecast = "Forecast: More of the same.";
            }

            Console.WriteLine(forecast);
        }
    }
}

