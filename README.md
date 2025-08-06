 Weather Monitoring System

A C# console application that simulates a real-time weather monitoring system using multiple design patterns. Developed as part of a software design assignment.

 Features

Singleton Pattern  
  The `WeatherData` class ensures only one instance collects and manages the weather data.

Observer Pattern
  Multiple display modules (`CurrentConditionsDisplay`, `StatisticsDisplay`, and `ForecastDisplay`) automatically update when the weather changes.

Decorator Pattern
  `CurrentConditionsDisplay` adds a timestamp to the output, enriching the display without modifying the original logic.

Factory Pattern
  The `WeatherStation` class uses a factory method to create different display observers based on user input.

Clean Architecture
  Project is structured with a class library (`WeatherLibrary`) and a separate console app (`WeatherApp`), following good separation of concerns.

 Project Structure"
 WeatherMonitoringSystem/
├── WeatherApp/ # Console Application (Main App)
│ └── Program.cs
├── WeatherLibrary/ # Class Library (Logic Layer)
│ ├── Interfaces/ # IWeatherObserver.cs, IDisplay.cs
│ ├── Core/ # WeatherData.cs, Display classes
│ └── Factory/ # WeatherStation.cs (Factory)
├── .gitignore
└── README.md

---

 How It Works

1. The console app (`WeatherApp`) creates one instance of `WeatherData` using the **Singleton** pattern.
2. It creates three display observers via the **Factory**:
   - `CurrentConditionsDisplay`
   - `StatisticsDisplay`
   - `ForecastDisplay`
3. These observers implement the **Observer** pattern — they auto-update when `WeatherData` changes.
4. The `CurrentConditionsDisplay` uses a **Decorator** approach to add a timestamp.
5. Weather data is randomly generated and pushed in 5 intervals.

---

 How to Run

 Prerequisites:
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- Visual Studio Code or Visual Studio

 Terminal Instructions:
1. Open a terminal in the root folder:
   ```bash
   cd WeatherMonitoringSystem

    Technologies Used
 C# 10 / .NET 9.0

 Visual Studio Code / Visual Studio 2022+

 Object-Oriented Programming (OOP)

 Git & GitHub

  Concepts Covered
Software Design Patterns

Modular Architecture

Real-time Data Simulation

Clean Code & Separation of Concerns

Interface-based Programming

 Author
Inderpreet Kaur
A00291274
Mobile Application Development – MAPD



