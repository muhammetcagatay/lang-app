using System;
using System.Collections.Generic;

namespace Scor.Models.Entities
{
    public partial class User
    {
        public User()
        {
            NotificationHistories = new HashSet<NotificationHistory>();
            ScorHistories = new HashSet<ScorHistory>();
        }

        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<NotificationHistory> NotificationHistories { get; set; }
        public virtual ICollection<ScorHistory> ScorHistories { get; set; }
    }
}
