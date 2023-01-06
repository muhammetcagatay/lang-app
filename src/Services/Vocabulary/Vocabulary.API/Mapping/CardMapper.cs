using AutoMapper;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Mapping
{
    public class CardMapper : Profile
    {
        public CardMapper()
        {
            CreateMap<Card, CardDto.CreateCardDto>().ReverseMap();
        }
    }
}
