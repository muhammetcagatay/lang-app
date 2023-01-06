using AuthServer.API.Models;

namespace AuthServer.API.Services.Users
{
    public interface IUserService
    {
        Task<User> GetByEmail(string email);
        Task<User> GetByRefreshToken(string refreshToken);
        Task AddRefreshToken(string email, Token token);
        Task Create(UserDto.CreateUserDto createUserDto);
    }
}
