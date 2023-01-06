using AutoMapper;
using Speaking.Models.Dtos;
using Speaking.Models.Entities;

namespace Speaking.Mapping
{
    public class ScorMapper : Profile
    {
        public ScorMapper()
        {
            CreateMap<Scor, ScorDto.ScorResponseDto>().ReverseMap();

        }
    }
}
