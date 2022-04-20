using Microsoft.AspNetCore.Mvc;

namespace ControleDePonto.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("/user")]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

        [HttpGet("/user")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPut("/user")]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }

        [HttpDelete("/user")]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}
