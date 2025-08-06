using System.Collections.Generic;
using WeatherLibrary.Interfaces;

namespace WeatherLibrary.Core
{
    /// <summary>
    /// Singleton class that stores and notifies weather observers.
    /// </summary>
    public class WeatherData
    {
        private static WeatherData? _instance;
        private static readonly object _lock = new();

        private readonly List<IWeatherObserver> observers = new();
        private float temperature, humidity, pressure;

        private WeatherData() { }

        public static WeatherData Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ??= new WeatherData();
                }
            }
        }

        public void RegisterObserver(IWeatherObserver observer) => observers.Add(observer);
        public void RemoveObserver(IWeatherObserver observer) => observers.Remove(observer);

        public void SetMeasurements(float temp, float hum, float pres)
        {
            temperature = temp;
            humidity = hum;
            pressure = pres;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
}
