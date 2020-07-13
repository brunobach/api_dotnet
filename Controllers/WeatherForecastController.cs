using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjectSchool_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(new {
                id = 1,
                nome = "Bruno Bach",
                sobrenome = "de Azevedo"
            });
        }
    }
}
