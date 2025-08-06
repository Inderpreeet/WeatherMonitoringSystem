using System;
using System.Collections.Generic;
using System.Linq;
using WeatherLibrary.Interfaces;

namespace WeatherLibrary.Core
{
    /// <summary>
    /// Observer that displays average, max, and min temperature.
    /// </summary>
    public class StatisticsDisplay : IWeatherObserver, IDisplay
    {
        private readonly List<float> temperatures = new();

        public void Update(float temp, float hum, float pres)
        {
            temperatures.Add(temp);
            Display();
        }

        public void Display()
        {
            float avg = temperatures.Average();
            float max = temperatures.Max();
            float min = temperatures.Min();

            Console.WriteLine($"Statistics: Avg = {avg:F1}°C, Max = {max:F1}°C, Min = {min:F1}°C");
        }
    }
}

