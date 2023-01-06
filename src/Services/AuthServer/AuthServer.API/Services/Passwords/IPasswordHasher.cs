namespace AuthServer.API.Services.Passwords
{
    public interface IPasswordHasher
    {
        public string HashPassword(string password);
        public bool VerifyPassword(string actualPassword, string hashedPassword);
    }
}
