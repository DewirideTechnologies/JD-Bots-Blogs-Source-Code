# MyMiddlewareApp

This project demonstrates how to create and use custom middleware in an ASP.NET Core Web API application using .NET 8 in Visual Studio.

## Table of Contents

- [Introduction](#introduction)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Code Overview](#code-overview)
- [Testing the Middleware](#testing-the-middleware)
- [Resources](#resources)
- [License](#license)

## Introduction

Middleware in ASP.NET Core is a key component of the request processing pipeline, enabling various tasks such as logging, authentication, and response modification. This project provides a simple example of custom middleware implementation in an ASP.NET Core Web API.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later with ASP.NET and web development workload installed

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/DewirideTechnologies/JD-Bots-Blogs-Source-Code.git
   cd JD-Bots-Blogs-Source-Code/src/csharp/MyMiddlewareApp
   ```

2. Open the project in Visual Studio:
   - Launch Visual Studio.
   - Select `Open a project or solution`.
   - Navigate to the cloned repository folder and select `MyMiddlewareApp.sln`.

3. Restore the dependencies:
   ```bash
   dotnet restore
   ```

## Usage

To run the application:

1. Press `F5` or click `Start` in Visual Studio to launch the application.
2. The API will be accessible at `https://localhost:7155`.

## Code Overview

For detailed instructions and code examples, please refer to the comprehensive guide available at [Creating Middleware in ASP.NET Core Web API with .NET 8 – A Comprehensive Guide](https://jd-bots.com/2024/07/02/creating-middleware-in-asp-net-core-web-api-with-net-8-a-comprehensive-guide/).

## Testing the Middleware

To test the middleware:

1. Run the application by pressing `F5` or clicking `Start` in Visual Studio.
2. Open a browser or use a tool like Postman to send a request to the API (e.g., `https://localhost:7155/WeatherForecast`).

## Resources

- [Official ASP.NET Core Middleware Documentation](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/)
- [Creating Middleware in ASP.NET Core Web API with .NET 8 – A Comprehensive Guide](https://jd-bots.com/2024/07/02/creating-middleware-in-asp-net-core-web-api-with-net-8-a-comprehensive-guide/)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.