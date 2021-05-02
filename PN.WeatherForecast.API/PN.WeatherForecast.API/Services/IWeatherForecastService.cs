using PN.WeatherForecast.API.Criteria;
using System.Threading.Tasks;

namespace PN.WeatherForecast.API.Services
{
    public interface IWeatherForecastService
    {
        Task<string> GetWeatherForecastData(GeoCoordinateCriteria criteria);
    }
}