using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;
using Vocabulary.API.Repositories;
using static Vocabulary.API.Models.Dtos.CardDto;

namespace Vocabulary.API.Services.Cards
{
    public class CardService : ICardService
    {
        private readonly IRepository<Card> _cardRepository;
        private readonly IRepository<Course> _courseRepository;
        private readonly IMapper _mapper;
        public CardService(IRepository<Card> cardRepository, IMapper mapper, IRepository<Course> courseRepository)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
            _courseRepository = courseRepository;
        }
        public async Task<Response<Card>> GetByIdAsync(int id)
        {
            var card = await _cardRepository.Where(x => x.Id ==id).Include(x => x.Words).FirstOrDefaultAsync();

            if (card == null)
            {
                return Response<Card>.Fail("not found card", 404);
            }

            return Response<Card>.Success(200, card);
        }
        public async Task<Response<NoContext>> Create(CardDto.CreateCardDto createCardDto)
        {
            var card = _mapper.Map<Card>(createCardDto);

            var course = _courseRepository.GetById(createCardDto.CourseId);

            if (course == null)
            {
                return Response<NoContext>.Fail("not found course", 404);
            }

            await _cardRepository.CreateAsync(card);

            await _cardRepository.CommitAsync();

            return Response<NoContext>.Success(200);
        }
        public Response<NoContext> Update(int id, CardDto.CreateCardDto updateCardDto)
        {
            var card = _cardRepository.GetById(id);

            if (card == null)
            {
                return Response<NoContext>.Fail("not found card",404);
            }

            var course = _courseRepository.GetById(updateCardDto.CourseId);

            if (course == null)
            {
                return Response<NoContext>.Fail("not found course", 404);
            }

            card.Title = updateCardDto.Title;
            card.CourseId = updateCardDto.CourseId;
            card.UpdatedDate = DateTime.Now;

            _cardRepository.Commit();

            return Response<NoContext>.Success(200);
        }
        public Response<NoContext> Delete(int id)
        {
            var card = _cardRepository.GetById(id);

            if (card == null)
            {
                return Response<NoContext>.Fail("not found", 404);
            }

            _cardRepository.Delete(card);
            _cardRepository.Commit();

            return Response<NoContext>.Success(200);
        }  
    }
}
