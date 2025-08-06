using System;
using WeatherLibrary.Interfaces;

namespace WeatherLibrary.Core
{
    /// <summary>
    /// Observer that displays current weather conditions with timestamp (Decorator).
    /// </summary>
    public class CurrentConditionsDisplay : IWeatherObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private string timestamp = "";

        public void Update(float temp, float hum, float pres)
        {
            temperature = temp;
            humidity = hum;
            timestamp = $"[{DateTime.Now}]";
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"{timestamp} Current Conditions: {temperature}°C, {humidity}% humidity.");
        }
    }
}
