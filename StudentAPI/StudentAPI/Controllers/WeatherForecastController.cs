using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"

//            "students": (
//{
//"name": "Alice"
//"age": 20,
//"hobbies": ("reading",
//"swimming", "coding"]
//                }
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //[HttpGet]
        //public string GetStudents()
        //{
        //    return "\"\\\"students\\\":[{\\\"name\\\":\\\"Alice\\\",\\\"age\\\":20,\\\"hobbies\\\":[\\\"reading\\\",\\\"swimming\\\",\\\"coding\\\"]},{\\\"name\\\":\\\"Bob\\\",\\\"age\\\":22,\\\"hobbies\\\":[\\\"painting\\\",\\\"dancing\\\",\\\"singing\\\"]}]\"";
        //}

    }
}