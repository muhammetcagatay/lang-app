using Vocabulary.API.Data;
using Vocabulary.API.Models.Entities;
using static Vocabulary.API.Models.Dtos.UserDto;

namespace Vocabulary.API.Services.Users
{
    public interface IUserService
    {
        Task<Response<User>> GetWithRegisteredCoursesByIdAsync(int id);
        Task<Response<User>> GetWithCoursesByIdAsync(int id);
        Task<Response<NoContext>> RegisterCourse(UserRegisterCourseDto userRegisterCourseDto);
        Task<Response<NoContext>> ReviewCard(UserReviewCardDto userReviewCardDto);
    }
}
