using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Speaking.Models.Dtos;
using Speaking.Services;

namespace Speaking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]

    public class SoundController : ControllerBase
    {
        private readonly ISoundService _soundService;
        public SoundController(ISoundService soundService)
        {
            _soundService = soundService;
        }
        [HttpPost]
        public async Task<IActionResult> ScorSound([FromForm]SoundDto.SoundRequestDto soundRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _soundService.ScorSound(soundRequestDto.UserId, soundRequestDto.TextId, soundRequestDto.AudioFile);

            return Ok(response);
        }
    }
}
