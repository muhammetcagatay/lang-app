using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;
using Vocabulary.API.Repositories;

namespace Vocabulary.API.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _courseRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        public CourseService(IRepository<Course> courseRepository, IMapper mapper, IRepository<User> userRepository)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<Response<List<Course>>> GetAllAsync()
        {
            var courses = await _courseRepository.GetAllAsync();

            return Response<List<Course>>.Success(200, courses);
        }
        public async Task<Response<Course>> GetByIdAsync(int id)
        {
            var course = await _courseRepository.Where(x => x.Id ==id).Include(x => x.Cards).FirstOrDefaultAsync();

            if (course == null)
            {
                return Response<Course>.Fail("not found course",404);
            }

            return Response<Course>.Success(200, course);
        }
        public async Task<Response<NoContext>> AddAsync(CourseDto.CreateCourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);

            var user = _userRepository.GetById(courseDto.UserId);

            if(user == null)
            {
                return Response<NoContext>.Fail("not found user", 404);
            }

            user.Courses.Add(course);

            await _courseRepository.CommitAsync();

            return Response<NoContext>.Success(200);
        }
        public Response<NoContext> Update(int id,CourseDto.CreateCourseDto courseDto)
        {
            var course = _courseRepository.GetById(id);

            if (course == null)
            {
                return Response<NoContext>.Fail("not found", 404);
            }

            var user = _userRepository.GetById(courseDto.UserId);

            if (user == null)
            {
                return Response<NoContext>.Fail("not found user", 404);
            }

            course.Title = courseDto.Title;
            course.Description = courseDto.Description;
            course.UserId = courseDto.UserId;
            course.UpdatedDate = DateTime.Now;

            _courseRepository.Commit();

            return Response<NoContext>.Success(200);

        }
        public Response<NoContext> Delete(int id)
        {
            var course = _courseRepository.GetById(id);

            if (course == null)
            {
                return Response<NoContext>.Fail("not found", 404);
            }

            _courseRepository.Delete(course);

            _courseRepository.Commit();

            return Response<NoContext>.Success(200);
        }   
    }
}
