using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace coreangular_test.Controllers
{
    [Produces("application/json")]
    [Route("api/Sensor")]
    public class SensorController : Controller
    {

        [HttpGet]
        public IEnumerable<int> Get()
        {
            return new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
    }
}