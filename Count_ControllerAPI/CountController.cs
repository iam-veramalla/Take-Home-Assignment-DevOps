
using Microsoft.AspNetCore.Mvc;

namespace CountAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountController : ControllerBase
    {
        private static int count = 0;

        [HttpGet]
        public IActionResult GetCount()
        {
            count++;
            return Ok(count);
        }
    }
}
