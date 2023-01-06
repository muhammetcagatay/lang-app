using AutoMapper;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Mapping
{
    public class WordMapper : Profile
    {
        public WordMapper()
        {
            CreateMap<Word, WordDto.CreateWordDto>().ReverseMap();
        }
    }
}
