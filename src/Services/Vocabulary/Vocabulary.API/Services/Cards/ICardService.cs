using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Services.Cards
{
    public interface ICardService
    {
        Task<Response<Card>> GetByIdAsync(int id);
        Task<Response<NoContext>> Create(CardDto.CreateCardDto createCardDto);
        Response<NoContext> Update(int id, CardDto.CreateCardDto updateCardDto);
        Response<NoContext> Delete(int id);

    }
}
