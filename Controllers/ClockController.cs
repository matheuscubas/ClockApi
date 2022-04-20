using Microsoft.AspNetCore.Mvc;

namespace ControleDePonto.Controllers
{
    [ApiController]
    public class ClockController : ControllerBase
    {
        [HttpPost("/clock")]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

        [HttpGet("/clock")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPut("/clock")]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }

        [HttpDelete("/clock")]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }
    }
}
