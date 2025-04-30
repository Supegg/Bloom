using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bloom.WebAPI48
{
    public class WeatherForecastController : ApiController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        // GET api/WeatherForecast
        public IEnumerable<WeatherForecast> GetWeatherForecast()
        {
            Random random = new Random();
            
            return Enumerable.Range(1,5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = random.Next(-20, 55),
                Summary = Summaries[random.Next(Summaries.Length)]
            }).ToArray();
        }
    }
}
