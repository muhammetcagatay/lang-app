using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vocabulary.API.Models.Dtos;
using Vocabulary.API.Services.Courses;

namespace Vocabulary.API.Controllers
{
    public class CourseController : BaseController
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateResult(await _courseService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return CreateResult(await _courseService.GetByIdAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseDto.CreateCourseDto createCourseDto)
        {
            return CreateResult(await _courseService.AddAsync(createCourseDto));
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id,CourseDto.CreateCourseDto updateCourseDto)
        {
            return CreateResult( _courseService.Update(id,updateCourseDto));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return CreateResult(_courseService.Delete(id));
        }

    }
}
