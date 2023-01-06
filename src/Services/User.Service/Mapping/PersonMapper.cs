using AutoMapper;
using User.Service.Models.Dtos;
using User.Service.Models.Entities;

namespace User.Service.Mapping
{
    public class PersonMapper : Profile
    {
        public PersonMapper()
        {
            CreateMap<Person, PersonDto.CreateDto>().ReverseMap();
            CreateMap<Person, PersonDto.UpdateDto>().ReverseMap();
            CreateMap<Person, PersonDto.GetDto>().ReverseMap();
        }
    }
}
