using AutoMapper;
using Scor.Models.Dtos;
using Scor.Models.Entities;

namespace Scor.Services
{
    public interface INotificationService
    {
        public List<NotificationHistoryDto.NotificationHistoryResponseDto> GetNotificationHistoriesByUserId(int userId);
        public NotificationHistoryDto.NotificationHistoryResponseDto GetNotificationHistoryById(int id);
        public bool SendNotification(string email,string content);

    }
    public class NotificationService : INotificationService
    {
        private readonly ScorDBContext _context;
        private readonly IMapper _mapper;
        public NotificationService(ScorDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<NotificationHistoryDto.NotificationHistoryResponseDto> GetNotificationHistoriesByUserId(int userId)
        {
            return new List<NotificationHistoryDto.NotificationHistoryResponseDto>();
        }

        public NotificationHistoryDto.NotificationHistoryResponseDto GetNotificationHistoryById(int id)
        {
            return new NotificationHistoryDto.NotificationHistoryResponseDto();
        }

        public bool SendNotification(string email, string content)
        {
            return true;
        }
    }
}
