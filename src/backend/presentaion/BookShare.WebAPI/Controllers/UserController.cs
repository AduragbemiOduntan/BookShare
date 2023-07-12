using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForUpdate;
using BookShare.ServiceRepository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShare.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public UserController(IServiceManager serviceManager) 
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUser() 
        {
             var gottenUsers = await _serviceManager.UserService.GetAllUsersAsync();
             return Ok(gottenUsers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(string userId) 
        {
            var gottenUser = await _serviceManager.UserService.GetUserByIdAsync(userId);
            return Ok(gottenUser);
        }
        //Look into this POST section
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserForCreation user)
        {
            if (user is null)
                return BadRequest("user object is null");
            var createdUser = await _serviceManager.UserService.CreateUserAsync(user);

            return Ok(createdUser);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateUser(string userId, UserForUpdate user)
        {
            if (user is null)
                return BadRequest("User entry is null");
            await _serviceManager.UserService.UpdateUserAsync(userId, user);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            await _serviceManager.UserService.DeleteUserAsynnc(userId);
            return NoContent();
        }
    }
}
