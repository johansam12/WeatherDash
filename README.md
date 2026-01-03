# WeatherDash
An interactive web application that fetches real-time weather data for cities worldwide. This is an Interactive Weather Dashboard built with Blazor, showcasing my ability to handle real-time data binding and external API integration.

## Tech Implemented
- **Framework**: Blazor Web App (.NET 8)
- **Rendering**: Interactive Server Mode
- **API**: Open-Meteo REST API
- **Styling**: Bootstrap 5 with custom glassmorphism

## Key Features
- **Real-time Search**: Fetches data dynamically based on user input.
- **Error Boundaries**: Implemented `try-catch` logic to handle API timeouts gracefully.
- **Dependency Injection**: Utilizes `IHttpClientFactory` for efficient socket management.

## How to Run?
1. Clone this repository.
2. Run `dotnet restore`.
3. Run `dotnet run` and open the localhost port shown in your terminal.
