using System;
using System.Collections.Generic;

namespace Vocabulary.API.Models.Entities
{
    public partial class CardSession : IEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsFinish { get; set; }
        public int TrueCount { get; set; }
        public int FalseCount { get; set; }
        public double? Scor { get; set; }
        public int UserId { get; set; }
        public int CardId { get; set; }

        public virtual Card Card { get; set; }
        public virtual User User { get; set; }
    }
}
