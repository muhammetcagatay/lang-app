using AuthServer.API.Models;

namespace AuthServer.API.Services.Tokens
{
    public interface ITokenService
    {
        Token CreateToken(string email);
        string CreateRefreshToken();
    }
}
