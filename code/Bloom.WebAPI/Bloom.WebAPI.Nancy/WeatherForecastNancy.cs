using Nancy;
using Nancy.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloom.WebAPI.Nancy
{
    public class WeatherForecastNancy : NancyModule
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastNancy() : base("/api/weatherforecast")
        {
            Get("/", _ =>
            {
                Random random = new Random();

                return Response.AsJson(Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = random.Next(-20, 55),
                    Summary = Summaries[random.Next(Summaries.Length)]
                }));
            });

        }
    }
}
