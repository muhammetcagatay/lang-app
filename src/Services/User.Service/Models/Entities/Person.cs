using System;
using System.Collections.Generic;

namespace User.Service.Models.Entities
{
    public partial class Person
    {
        public Person()
        {
            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            IsDelete = false;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
