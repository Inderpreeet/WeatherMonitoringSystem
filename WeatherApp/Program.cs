using System;
using System.Threading;
using WeatherLibrary.Core;
using WeatherLibrary.Factory;
using WeatherLibrary.Interfaces;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🌦️ Weather Monitoring System Starting...\n");

            var weatherData = WeatherData.Instance;

            IWeatherObserver current = WeatherStation.CreateDisplay("current");
            IWeatherObserver stats = WeatherStation.CreateDisplay("stats");
            IWeatherObserver forecast = WeatherStation.CreateDisplay("forecast");

            weatherData.RegisterObserver(current);
            weatherData.RegisterObserver(stats);
            weatherData.RegisterObserver(forecast);

            Random rand = new();

            for (int i = 1; i <= 5; i++)
            {
                float temp = rand.Next(15, 35);
                float hum = rand.Next(30, 90);
                float pres = rand.Next(990, 1025);

                Console.WriteLine($"📡 Update #{i}:");
                weatherData.SetMeasurements(temp, hum, pres);
                Console.WriteLine(new string('-', 50));
                Thread.Sleep(1500);
            }

            Console.WriteLine("\n✅ Monitoring Complete.");
        }
    }
}
