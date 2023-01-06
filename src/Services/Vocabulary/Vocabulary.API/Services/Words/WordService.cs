using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;
using Vocabulary.API.Repositories;
using static Vocabulary.API.Models.Dtos.WordDto;

namespace Vocabulary.API.Services.Words
{
    public class WordService : IWordService
    {
        private readonly IRepository<Word> _wordRepository;
        private readonly IRepository<Card> _cardRepository;
        private readonly IMapper _mapper;
        public WordService(IRepository<Word> wordRepository, IMapper mapper, IRepository<Card> cardRepository)
        {
            _wordRepository = wordRepository;
            _mapper = mapper;
            _cardRepository = cardRepository;
        }
        public async Task<Response<Word>> GetByIdAsync(int id)
        {
            var word = await _wordRepository.Where(x => x.Id == id).Include(x => x.WordAnswers).FirstOrDefaultAsync();

            if (word == null)
            {
                return Response<Word>.Fail("not found word", 404);
            }

            return Response<Word>.Success(200, word);
        }
        public Response<NoContext> Create(WordDto.CreateWordDto createWordDto)
        {
            var word = _mapper.Map<Word>(createWordDto);

            var card = _cardRepository.GetById(createWordDto.CardId);

            if(card== null)
            {
                return Response<NoContext>.Fail("Not found card", 404);
            }

            var wordAnswers = new List<WordAnswer>();

            wordAnswers.Add(new WordAnswer() { Answer = createWordDto.TrueAnswer, IsTrue = true });

            foreach (var falseAnswer in createWordDto.FalseAnswers)
            {
                wordAnswers.Add(new WordAnswer()
                {
                    Answer = falseAnswer,
                    IsTrue = false,
                });

            }

            word.WordAnswers = wordAnswers;

            _wordRepository.Create(word);
            _wordRepository.Commit();

            return Response<NoContext>.Success(200);
        }
        public Response<NoContext> Update(int id, WordDto.CreateWordDto updateWordDto)
        {
            var word = _wordRepository.Where(x => x.Id==id).Include(x => x.WordAnswers).FirstOrDefault();

            if(word == null)
            {
                return Response<NoContext>.Fail("Not found", 404);
            }

            var card = _cardRepository.GetById(updateWordDto.CardId);

            if (card == null)
            {
                return Response<NoContext>.Fail("Not found card", 404);
            }

            var wordAnswers = new List<WordAnswer>();

            wordAnswers.Add(new WordAnswer() { Answer = updateWordDto.TrueAnswer, IsTrue = true });

            foreach (var falseAnswer in updateWordDto.FalseAnswers)
            {
                wordAnswers.Add(new WordAnswer()
                {
                    Answer = falseAnswer,
                    IsTrue = false,
                });

            }

            word.Context = updateWordDto.Context;
            word.CardId = updateWordDto.CardId;
            word.UpdatedDate = DateTime.Now;

            _wordRepository.Commit();

            return Response<NoContext>.Success(200);
        }
        public Response<NoContext> Delete(int id)
        {
            var word = _wordRepository.GetById(id);

            if (word == null)
            {
                return Response<NoContext>.Fail("Not found", 404);
            }

            _wordRepository.Delete(word);
            _wordRepository.Commit();

            return Response<NoContext>.Success(200);
        }     
    }
}
