namespace User.Service.Models.Dtos
{
    public class PersonDto
    {
        public class GetDto
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public int? Age { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }
        public class CreateDto
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public int? Age { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class UpdateDto
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public int? Age { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class RequestDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
