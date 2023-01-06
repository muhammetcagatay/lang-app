namespace AuthServer.API.Models
{
    public class UserDto
    {
        public class CreateUserDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class UpdateUserDto 
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class LoginUserDto
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class RefreshTokenUserDto
        {
            public string RefreshToken { get; set; }
        }
    }
}
