using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scor.Models.Dtos;
using Scor.Services;

namespace Scor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpGet("ByUserId/{userId}")]
        public IActionResult GetNotificationHistoriesByUserId(int userId)
        {
            var histories = _notificationService.GetNotificationHistoriesByUserId(userId);
            return Ok(histories);
        }
        [HttpGet("ById/{id}")]
        public IActionResult GetNotificationHistoriesById(int id)
        {
            var history = _notificationService.GetNotificationHistoryById(id);
            return Ok(history);
        }
        [HttpPost]
        public IActionResult SendNotification(NotificationHistoryDto.SendNotificationDto sendNotificationDto)
        {
            var isSend = _notificationService.SendNotification(sendNotificationDto.SentEmailAddress, sendNotificationDto.EmailContent);
            return Ok(isSend);
        }
    }
}
