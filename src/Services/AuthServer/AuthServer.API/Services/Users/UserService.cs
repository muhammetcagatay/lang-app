using AuthServer.API.Models;
using AuthServer.API.Services.Passwords;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.API.Services.Users
{
    public class UserService : IUserService
    {
        private readonly AuthServerDBContext _context;
        private readonly IPasswordHasher _passwordHasher;
        public UserService(AuthServerDBContext context)
        {
            _context = context;
        }
        public async Task<User> GetByEmail(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email && !x.IsDelete);

            return user;
        }
        public async Task<User> GetByRefreshToken(string refreshToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.RefreshToken == refreshToken && !x.IsDelete);

            return user;
        }
        public async Task AddRefreshToken(string email, Token token)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Email == email && !x.IsDelete);

            if (user != null)
            {
                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenEndDate = token.Expiration.AddHours(5);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Create(UserDto.CreateUserDto createUserDto)
        {
            var user = new User()
            {
                Email = createUserDto.Email,
                Password = createUserDto.Password,
                CreatedDate = DateTime.UtcNow,
                UpdatedDate= DateTime.MinValue,
                IsDelete= false,
                RefreshTokenEndDate= DateTime.MinValue,
            };

            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();
        }
    }
}
