using System;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Data
{
    public class WeatherForecastService
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }

        //public Task<string> CalculateHomeLoanRepayment(calculatorNameInput input)
        //{
        //    // Equation here
        //    return null;
        //}

    }

    //public class calculatorNameInput
    //{
    //    public int repayment { get; set; }
    //    public int homeloanvalue { get; set; }
    //    public int homevalue { get; set; }
    //    public int interestRate { get; set; }
    //}
}
