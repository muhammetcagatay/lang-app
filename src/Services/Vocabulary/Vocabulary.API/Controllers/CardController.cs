using Microsoft.AspNetCore.Mvc;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Services.Cards;

namespace Vocabulary.API.Controllers
{
    public class CardController : BaseController
    {
        private readonly ICardService _cardService;
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateResult(await _cardService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CardDto.CreateCardDto createCardDto)
        {
            return CreateResult(await _cardService.Create(createCardDto));
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,CardDto.CreateCardDto updateCardDto)
        {
            return CreateResult(_cardService.Update(id, updateCardDto));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return CreateResult(_cardService.Delete(id));
        }
    }
}
