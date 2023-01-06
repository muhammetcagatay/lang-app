using System;
using System.Collections.Generic;

namespace Speaking.Models.Entities
{
    public partial class Scor
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
        public int TrueWord { get; set; }
        public int FalseWord { get; set; }
        public double AccuracyRate { get; set; }
        public int UserId { get; set; }
        public int TextId { get; set; }

        public virtual Text Text { get; set; }
        public virtual User User { get; set; }
    }
}
