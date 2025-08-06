namespace WeatherLibrary.Interfaces
{
    /// <summary>
    /// Custom observer interface for weather updates.
    /// </summary>
    public interface IWeatherObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}

