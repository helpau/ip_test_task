using Microsoft.AspNetCore.Mvc;

namespace ip.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CalcController> _logger;

        public CalcController(ILogger<CalcController> logger)
        {
            _logger = logger;
        }


        public CalcController()
        {

        }

        [HttpGet(Name = "GetCalc")]
        public Calc Get(int a, int b)
        {
            return new Calc
            {
                Summary = a + b
            };
        }
    }
}
