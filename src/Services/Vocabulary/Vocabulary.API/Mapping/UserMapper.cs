using AutoMapper;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Mapping
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<CardSession, UserDto.UserReviewCardDto>().ReverseMap();
        }
    }
}
