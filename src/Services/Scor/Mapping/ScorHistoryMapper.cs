using AutoMapper;
using Scor.Models.Dtos;
using Scor.Models.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Scor.Mapping
{
    public class ScorHistoryMapper : Profile
    {
        public ScorHistoryMapper()
        {
            CreateMap<ScorHistory, ScorHistoryDto.ScorHistoryResponseDto>().ReverseMap();

        }
    }
}
