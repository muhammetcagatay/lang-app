namespace Scor.Models.Dtos
{
    public class NotificationHistoryDto
    {
        public class NotificationHistoryResponseDto
        {
            public string SentEmailAddress { get; set; } = null!;
            public string EmailContent { get; set; } = null!;
            public DateTime SentDate { get; set; }
        }
        public class SendNotificationDto
        {
            public string SentEmailAddress { get; set; } = null!;
            public string EmailContent { get; set; } = null!;
        }
    }
}
