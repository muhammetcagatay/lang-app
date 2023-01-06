using System;
using System.Collections.Generic;

namespace Scor.Models.Entities
{
    public partial class ScorHistory
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int TrueAnswer { get; set; }
        public int FalseAnswer { get; set; }
        public DateTime? TotalTime { get; set; }
        public int Scor { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
