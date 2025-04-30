using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bloom.WebAPI.Nancy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8087/";
            // string swaggerUrl = $"{baseAddress}api/swagger"; // using Nancy.Swagger;

            using (var host = new NancyHost(new Uri(baseAddress)))
            {
                host.Start();

                HttpClient client = new HttpClient();
                var response = client.GetAsync(baseAddress + "api/WeatherForecast").Result;
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }

        }
    }
}
