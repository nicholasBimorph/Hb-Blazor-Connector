using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HbBlazorConnector.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public /*Task<WeatherForecast[]>*/ Task GetForecastAsync(DateTime startDate)
        {
            //var rng = new Random();
            //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = startDate.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //}).ToArray());

          return  Task.Run(() => Thread.Sleep(500));
        }
    }
}
