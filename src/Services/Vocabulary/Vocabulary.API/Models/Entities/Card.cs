using System;
using System.Collections.Generic;

namespace Vocabulary.API.Models.Entities
{
    public partial class Card : IEntity
    {
        public Card()
        {
            CardSessions = new HashSet<CardSession>();
            Words = new HashSet<Word>();
        }
        public string Title { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<CardSession> CardSessions { get; set; }
        public virtual ICollection<Word> Words { get; set; }
    }
}
