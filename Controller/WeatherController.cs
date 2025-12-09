using Microsoft.AspNetCore.Mvc;

namespace SwaggerHierarchySupportExample.Controller;

[ApiController]
[Route("/api/[controller]/[action]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    [Tags("Weather:Forecast")]
    public IActionResult GetWeatherForecast()
    {
        return Ok();
    }

    [HttpGet]
    [Tags("Weather:Days")]
    public IActionResult GetWeatherDay()
    {
        return Ok();
    }
}
