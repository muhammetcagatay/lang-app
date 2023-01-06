using AutoMapper;
using Speaking.Models.Dtos;
using Speaking.Models.Entities;

namespace Speaking.Mapping
{
    public class TextMapper : Profile
    {
        public TextMapper()
        {
            CreateMap<Text, TextDto.TextResponseDto>().ReverseMap();
        }
    }
}
