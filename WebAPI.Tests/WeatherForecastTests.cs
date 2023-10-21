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
}