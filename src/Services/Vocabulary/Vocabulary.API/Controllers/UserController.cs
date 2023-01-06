using Microsoft.AspNetCore.Mvc;
using Vocabulary.API.Services.Users;
using static Vocabulary.API.Models.Dtos.UserDto;



namespace Vocabulary.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("courses/{id}")]
        public async Task<IActionResult> GetWithCourses(int id)
        {
            return CreateResult(await _userService.GetWithCoursesByIdAsync(id));
        }
        [HttpGet("registered/{id}")]
        public async Task<IActionResult> GetWithRegisteredCourses(int id) 
        {
            return CreateResult(await _userService.GetWithRegisteredCoursesByIdAsync(id));
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterCourse(UserRegisterCourseDto userRegisterCourseDto)
        {
            return CreateResult(await _userService.RegisterCourse(userRegisterCourseDto));
        }
        [HttpPost("review")]
        public async Task<IActionResult> ReviewCard(UserReviewCardDto userReviewCardDto)
        {
            return CreateResult(await _userService.ReviewCard(userReviewCardDto));
        }
    }
}
