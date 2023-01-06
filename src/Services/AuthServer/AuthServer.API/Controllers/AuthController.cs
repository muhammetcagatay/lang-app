using AuthServer.API.Data;
using AuthServer.API.Models;
using AuthServer.API.Services.Passwords;
using AuthServer.API.Services.Tokens;
using AuthServer.API.Services.Users;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.API.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHasher _passwordHasher;
        public AuthController(IUserService userService, ITokenService tokenService, IPasswordHasher passwordHasher)
        {
            _userService = userService;
            _tokenService = tokenService;
            _passwordHasher = passwordHasher;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(UserDto.CreateUserDto createUserDto)
        {
            await _userService.Create(createUserDto);

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto.LoginUserDto userDto)
        {
            var user = await _userService.GetByEmail(userDto.Email);

            if (user == null)
            {
                return CreateResult(Response<NoContext>.Fail("user not found", 404));
            }

            if (userDto.Password.Replace(" ","").ToLower() != user.Password.Replace(" ", "").ToLower())
            {
                return CreateResult(Response<NoContext>.Fail("invalid password", 404));
            }

            var token = _tokenService.CreateToken(user.Email);

            await _userService.AddRefreshToken(user.Email, token);

            return CreateResult(Response<Token>.Success(200, token));
        }

        [HttpPost("refreshtoken")]
        public async Task<IActionResult> RefreshToken(UserDto.RefreshTokenUserDto refreshTokenDto)
        {
            var user = await _userService.GetByRefreshToken(refreshTokenDto.RefreshToken);

            if (user == null)
            {
                return CreateResult(Response<NoContext>.Fail("invalid refresh token", 404));
            }
            if (user.RefreshTokenEndDate < DateTime.Now)
            {
                return CreateResult(Response<NoContext>.Fail("refresh token expired", 404));
            }
            var token = _tokenService.CreateToken(user.Email);

            await _userService.AddRefreshToken(user.Email, token);

            return CreateResult(Response<Token>.Success(200, token));
        }
    }
}
