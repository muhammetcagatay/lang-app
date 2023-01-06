using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Services.Words
{
    public interface IWordService
    {
        Task<Response<Word>> GetByIdAsync(int id);
        Response<NoContext> Create(WordDto.CreateWordDto createWordDto);
        Response<NoContext> Update(int id, WordDto.CreateWordDto updateWordDto);
        Response<NoContext> Delete(int id);
    }
}
