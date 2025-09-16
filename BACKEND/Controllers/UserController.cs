using BACKEND.Models.DTOs;
using BACKEND.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BACKEND.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserDTOAdminRead>>> Get()
        {
            var users = await _userService.AdminGetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserDTORead>> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null) 
            {
                return NotFound(new { message = "User not found" });
            }
            return Ok(user);
        }

        [HttpGet("admin/{id}")]
        public async Task<ActionResult<UserDTOAdminRead>> AdminGetById(int id)
        {
            var user = await _userService.AdminGetByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }
            return Ok(user);
        }


        [HttpPost]
        public async Task<ActionResult<UserDTORead>> Post([FromBody] UserDTOWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _userService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = user.UserId }, user);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTORead>> Put(int id, [FromBody] UserDTOWrite dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _userService.UpdateAsync(id, dto);
            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }
            return Ok(user);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _userService.DeleteAsync(id);
            if (!result)
            {
                return NotFound(new {message = "User not found" });
            }
            return NoContent();
        }
    }
}
