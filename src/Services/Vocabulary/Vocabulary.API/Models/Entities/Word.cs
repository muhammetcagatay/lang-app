using System;
using System.Collections.Generic;

namespace Vocabulary.API.Models.Entities
{
    public partial class Word : IEntity
    {
        public Word()
        {
            WordAnswers = new HashSet<WordAnswer>();
        }
        public string Context { get; set; }
        public int CardId { get; set; }

        public virtual Card Card { get; set; }
        public virtual ICollection<WordAnswer> WordAnswers { get; set; }
    }
}
