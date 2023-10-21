using System;
using WebAPI.Controllers;
using WebAPI.Exceptions;

namespace WebAPI.Tests;

[TestClass]
public class WeatherForecastTests
{
    private readonly WeatherForecastService _weatherForecastService;

    public WeatherForecastTests()
    {
        _weatherForecastService = new WeatherForecastService();
    }

    [TestMethod]
    public void ShouldThrowAnExceptionWhenCityIsDifferentOfSP()
    {
        const string cityDiffSP = "Gru";

        Assert.ThrowsException<CityNotFoundException>(() =>
            _weatherForecastService.GetTemperature(cityDiffSP)
        );

    }

    [TestMethod]
    public void ShouldReturnAnArrayOfTempeture()
    {
        // AAA
        string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        List<WeatherForecast> temperatures = new List<WeatherForecast>
        {
            new WeatherForecast {
            Date = DateTime.Now.AddDays(1),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            },

            new WeatherForecast {
            Date = DateTime.Now.AddDays(1),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            },

            new WeatherForecast {
            Date = DateTime.Now.AddDays(1),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            },
        };

        var a = _weatherForecastService.GetTemperature("SP");
        Assert.AreEqual(temperatures.Count, 3);

        Assert.AreEqual(a, temperatures);
    }

}



