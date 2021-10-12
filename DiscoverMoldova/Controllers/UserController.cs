using DiscoverMoldova.Core.Dtos;
using DiscoverMoldova.Core.Dtos.User;
using DiscoverMoldova.Core.Exceptions;
using DiscoverMoldova.Core.Interfaces;
using DiscoverMoldova.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscoverMoldova.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [ApiExceptionFilter]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterUser([FromBody]CreateUserDto user)
        {
            await _userService.RegisterUserAsync(user);
            return Ok();
        }

        [HttpGet("{id}")]
        [ApiExceptionFilter]
        public async Task<IActionResult> GetUserById(long id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound("User with such id does not exist");
            }
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpPatch("{id}")]
        [ApiExceptionFilter]
        public async Task<IActionResult> UpdateUserDetails([FromBody] UpdateUserDto updateUserDto, long id)
        {
            await _userService.UpdateUserDetailsAsync(updateUserDto, id);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(long id)
        {
            await _userService.DeleteUserByIdAsync(id);
            return NoContent();
        }

        [HttpPost("login")]
        [ApiExceptionFilter]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
        {
            var result = await _userService.Login(loginUserDto);
            return Ok(result);
        }
    }
}
