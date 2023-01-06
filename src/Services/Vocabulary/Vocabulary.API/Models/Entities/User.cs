using System;
using System.Collections.Generic;

namespace Vocabulary.API.Models.Entities
{
    public partial class User : IEntity
    {
        public User()
        {
            CardSessions = new HashSet<CardSession>();
            Courses = new HashSet<Course>();
            CoursesNavigation = new HashSet<Course>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<CardSession> CardSessions { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Course> CoursesNavigation { get; set; }
    }
}
