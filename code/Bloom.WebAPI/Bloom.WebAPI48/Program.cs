using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bloom.WebAPI48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8086/";
            string swaggerUrl = $"{baseAddress}swagger/ui/index"; // 注意不同版本的Swagger UI 路径可能不同

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpClient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/WeatherForecast").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}
