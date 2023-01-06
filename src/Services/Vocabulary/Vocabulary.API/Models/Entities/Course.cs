using System;
using System.Collections.Generic;

namespace Vocabulary.API.Models.Entities
{
    public partial class Course : IEntity
    {
        public Course()
        {
            Cards = new HashSet<Card>();
            Users = new HashSet<User>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Card> Cards { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
