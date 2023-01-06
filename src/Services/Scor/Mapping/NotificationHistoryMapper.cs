using AutoMapper;
using Scor.Models.Dtos;
using Scor.Models.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Scor.Mapping
{
    public class NotificationHistoryMapper : Profile
    {
        public NotificationHistoryMapper()
        {
            CreateMap<NotificationHistory, NotificationHistoryDto.NotificationHistoryResponseDto>().ReverseMap();
            CreateMap<NotificationHistory, NotificationHistoryDto.SendNotificationDto>().ReverseMap();

        }
    }
}
