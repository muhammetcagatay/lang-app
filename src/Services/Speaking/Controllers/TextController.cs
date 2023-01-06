using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Speaking.Services;

namespace Speaking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TextController : ControllerBase
    {
        private readonly ITextService _textService;
        public TextController(ITextService textService)
        {
            _textService = textService;
        }

        [HttpGet]
        public IActionResult GetText()
        {
            var text = _textService.GetRandomText();

            return Ok(text);
        }
    }
}
