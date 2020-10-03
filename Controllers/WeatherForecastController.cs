using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DockerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static string[] Summaries;

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DockerDbContext dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DockerDbContext dbContext)
        {
            _logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Summary> Get()
        {
            return dbContext.Summaries.Select(x => new Summary { Name= x.Name}).ToList();



        }
    }
}
