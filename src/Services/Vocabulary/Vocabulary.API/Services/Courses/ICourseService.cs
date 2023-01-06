using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;

namespace Vocabulary.API.Services.Courses
{
    public interface ICourseService
    {
        Task<Response<List<Course>>> GetAllAsync();
        Task<Response<Course>> GetByIdAsync(int id);
        Task<Response<NoContext>> AddAsync(CourseDto.CreateCourseDto courseDto);
        Response<NoContext> Update(int id,CourseDto.CreateCourseDto courseDto);
        Response<NoContext> Delete(int id);
    }
}
