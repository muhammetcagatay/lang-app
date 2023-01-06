using System;
using System.Collections.Generic;

namespace Scor.Models.Entities
{
    public partial class NotificationHistory
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
        public string SentEmailAddress { get; set; } = null!;
        public string EmailContent { get; set; } = null!;
        public DateTime SentDate { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
