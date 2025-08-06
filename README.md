

# Weather Monitoring System

A C# console application simulating real-time weather monitoring, developed for a software design assignment. The project demonstrates several core object-oriented design patterns and clean architecture principles.

## Features

- **Singleton Pattern**  
  The `WeatherData` class ensures only one instance manages weather data collection.

- **Observer Pattern**  
  Multiple display modules (`CurrentConditionsDisplay`, `StatisticsDisplay`, `ForecastDisplay`) automatically update when weather data changes.

- **Decorator Pattern**  
  The `CurrentConditionsDisplay` uses a decorator to add a timestamp to its output, enhancing display without modifying the original logic.

- **Factory Pattern**  
  The `WeatherStation` class uses a factory method to create different display observers based on user input.

- **Clean Architecture**  
  The solution is split into a class library (`WeatherLibrary`) for business logic and a console app (`WeatherApp`), ensuring separation of concerns and maintainability.

## Project Structure

```
WeatherMonitoringSystem/
├── WeatherApp/            # Console Application (Entry Point)
│   └── Program.cs
├── WeatherLibrary/        # Class Library (Core Logic)
│   ├── Interfaces/        # IWeatherObserver.cs, IDisplay.cs
│   ├── Core/              # WeatherData.cs, Display classes
│   └── Factory/           # WeatherStation.cs (Factory Pattern)
├── .gitignore
└── README.md
```

## How It Works

1. The console app (`WeatherApp`) creates a single instance of `WeatherData` (Singleton).
2. It creates three display observers using the Factory pattern:
    - `CurrentConditionsDisplay`
    - `StatisticsDisplay`
    - `ForecastDisplay`
3. Observers use the Observer pattern to auto-update when weather data changes.
4. The `CurrentConditionsDisplay` decorates its output with a timestamp.
5. Weather data is randomly generated and pushed at five intervals for demonstration.

## Example Output

```
[12:01:34] Current Conditions: 22°C, 60% Humidity
Statistics: Avg Temp: 21.5°C, Max Temp: 23°C, Min Temp: 20°C
Forecast: Expect warmer weather tomorrow
```

## Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code or Visual Studio 2022+

### Running the Application

1. Open a terminal in the project root directory:
    ```bash
    cd WeatherMonitoringSystem
    ```
2. Build and run the console application:
    ```bash
    dotnet run --project WeatherApp
    ```

## Technologies Used

- C# 10 / .NET 9.0
- Visual Studio Code / Visual Studio 2022+
- Object-Oriented Programming (OOP)
- Git & GitHub

## Concepts Covered

- Software Design Patterns (Singleton, Observer, Decorator, Factory)
- Modular Architecture & Clean Code
- Real-time Data Simulation
- Separation of Concerns
- Interface-based Programming

## Author

**Inderpreet Kaur**  
Student ID: A00291274  
Mobile Application Development – MAPD
