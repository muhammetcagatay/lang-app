using AutoMapper;
using Scor.Models.Dtos;
using Scor.Models.Entities;

namespace Scor.Services
{
    public interface IScorService
    {
        public ScorHistoryDto.ScorHistoryResponseDto GetWeeklyScor(int userId);
        public ScorHistoryDto.ScorHistoryResponseDto GetMonthlyScor(int userId);
        public ScorHistoryDto.ScorHistoryResponseDto GetYearlyScor(int userId);
    }
    public class ScorService : IScorService
    {
        private readonly ScorDBContext _context;
        private readonly IMapper _mapper;
        public ScorService(ScorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ScorHistoryDto.ScorHistoryResponseDto GetMonthlyScor(int userId)
        {
            return new ScorHistoryDto.ScorHistoryResponseDto();
        }

        public ScorHistoryDto.ScorHistoryResponseDto GetWeeklyScor(int userId)
        {
            return new ScorHistoryDto.ScorHistoryResponseDto();
        }

        public ScorHistoryDto.ScorHistoryResponseDto GetYearlyScor(int userId)
        {
            return new ScorHistoryDto.ScorHistoryResponseDto();
        }
    }
}
