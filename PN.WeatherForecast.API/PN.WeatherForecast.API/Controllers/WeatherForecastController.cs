namespace PN.WeatherForecast.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using PN.WeatherForecast.API.Criteria;
    using PN.WeatherForecast.API.Services;
    using System.Threading.Tasks;

    [Route("[controller]/[action]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherService;

        public WeatherForecastController(IWeatherForecastService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetWeatherData([FromQuery] GeoCoordinateCriteria criteria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var data = await _weatherService.GetWeatherForecastData(criteria);

            return Ok(data);
        }
    }
}