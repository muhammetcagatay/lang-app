using System;
using System.Collections.Generic;

namespace Speaking.Models.Entities
{
    public partial class User
    {
        public User()
        {
            Scors = new HashSet<Scor>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Scor> Scors { get; set; }
    }
}
