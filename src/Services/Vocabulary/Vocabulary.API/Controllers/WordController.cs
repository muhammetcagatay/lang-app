using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Services.Words;

namespace Vocabulary.API.Controllers
{
    public class WordController : BaseController
    {
        private readonly IWordService _wordService;
        public WordController(IWordService wordService)
        {
            _wordService = wordService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateResult(await _wordService.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult Create(WordDto.CreateWordDto createWordDto)
        {
            return CreateResult(_wordService.Create(createWordDto));
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,WordDto.CreateWordDto updateWordDto)
        {
            return CreateResult(_wordService.Update(id, updateWordDto));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return CreateResult(_wordService.Delete(id));
        }
    }
}
