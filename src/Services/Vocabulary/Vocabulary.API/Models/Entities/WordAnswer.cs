using System;
using System.Collections.Generic;

namespace Vocabulary.API.Models.Entities
{
    public partial class WordAnswer :IEntity
    {
        public bool IsTrue { get; set; }
        public string Answer { get; set; }
        public int WordId { get; set; }

        public virtual Word Word { get; set; }
    }
}
