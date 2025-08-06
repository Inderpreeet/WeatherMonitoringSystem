# 🌦️ Weather Monitoring System

A C# console application that simulates a real-time weather monitoring system using multiple design patterns. Developed as part of a software design assignment.

## ✅ Features

- **Singleton Pattern**  
  The `WeatherData` class ensures only one instance collects and manages the weather data.

- **Observer Pattern**  
  Multiple display modules (`CurrentConditionsDisplay`, `StatisticsDisplay`, and `ForecastDisplay`) automatically update when the weather changes.

- **Decorator Pattern**  
  `CurrentConditionsDisplay` adds a timestamp to the output, enriching the display without modifying the original logic.

- **Factory Pattern**  
  The `WeatherStation` class uses a factory method to create different display observers based on user input.

- **Clean Architecture**  
  Project is structured with a class library (`WeatherLibrary`) and a separate console app (`WeatherApp`), following good separation of concerns.

---

## 📁 Project Structure

