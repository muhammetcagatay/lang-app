using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.Service.Models.Dtos;
using User.Service.Services;

namespace User.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("GetById/{id}")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            if(user != null)
            {
                return Ok(user);
            }

            return NotFound("Not found user");
        }
        [HttpGet("GetByEmail/{email}")]
        [Authorize]
        public IActionResult GetByEmail(string email)
        {
            var user = _userService.GetByEmail(email);

            if (user != null)
            {
                return Ok(user);
            }

            return NotFound("Not found user");
        }
        [HttpPost]
        public IActionResult Create(PersonDto.CreateDto createDto)
        {
            var user = _userService.GetByEmail(createDto.Email);

            if(user != null)
            {
                return Ok("The user with this email already exists");
            }

            _userService.Create(createDto);

            return Ok();
        }
        [HttpPut("{id}")]
        [Authorize]
        public IActionResult Update(int id,PersonDto.UpdateDto updateDto)
        {
            _userService.Update(id, updateDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
    }
}
