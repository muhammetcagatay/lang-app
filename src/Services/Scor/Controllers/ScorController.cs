using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scor.Services;

namespace Scor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ScorController : ControllerBase
    {
        private readonly IScorService _scorService;
        public ScorController(IScorService scorService)
        {
            _scorService = scorService;
        }
        [HttpGet("weekly/{userId}")]
        public IActionResult GetWeeklyScor(int userId)
        {
            var scor = _scorService.GetWeeklyScor(userId);

            return Ok(scor);
        }
        [HttpGet("monthly/{userId}")]
        public IActionResult GetMonthlyScor(int userId)
        {
            var scor = _scorService.GetMonthlyScor(userId);

            return Ok(scor);
        }
        [HttpGet("yearly/{userId}")]
        public IActionResult GetYearlyScor(int userId)
        {
            var scor = _scorService.GetYearlyScor(userId);

            return Ok(scor);
        }
    }
}
