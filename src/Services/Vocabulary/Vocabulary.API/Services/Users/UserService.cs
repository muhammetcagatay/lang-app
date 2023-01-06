using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vocabulary.API.Data;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Models.Entities;
using Vocabulary.API.Repositories;

namespace Vocabulary.API.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Course> _courseRepository;
        private readonly IRepository<CardSession> _cardSessionRepository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> userRepository, IMapper mapper, IRepository<Course> courseRepository, IRepository<CardSession> cardSessionRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _courseRepository = courseRepository;
            _cardSessionRepository = cardSessionRepository;
        }
        public async Task<Response<User>> GetWithRegisteredCoursesByIdAsync(int id)
        {
            var user = await _userRepository.Where(x => x.Id == id).Include(x => x.CoursesNavigation).IgnoreAutoIncludes().FirstOrDefaultAsync();

            return Response<User>.Success(200, user);
        }
        public async Task<Response<User>> GetWithCoursesByIdAsync(int id)
        {
            var user = await _userRepository.Where(x => x.Id==id).Include(x => x.Courses).FirstOrDefaultAsync();

            return Response<User>.Success(200, user);
        }
        public async Task<Response<NoContext>> RegisterCourse(UserDto.UserRegisterCourseDto userRegisterCourseDto)
        {
            var user = await _userRepository.Where(x => x.Id == userRegisterCourseDto.UserId).FirstOrDefaultAsync();

            if(user==null)
            {
                return Response<NoContext>.Fail("Not found user",400);
            }

            var course = await _courseRepository.Where(x => x.Id ==userRegisterCourseDto.CourseId).FirstOrDefaultAsync();

            if(course==null) 
            {
                return Response<NoContext>.Fail("Not found course", 400);
            }

            user.CoursesNavigation.Add(course);

            await _userRepository.CommitAsync();

            return Response<NoContext>.Success(200);
        }
        public async Task<Response<NoContext>> ReviewCard(UserDto.UserReviewCardDto userReviewCardDto)
        {
            var cardSession = _mapper.Map<CardSession>(userReviewCardDto);

            await _cardSessionRepository.CreateAsync(cardSession);

            await _cardSessionRepository.CommitAsync();

            return Response<NoContext>.Success(200);
        }
    }
}
