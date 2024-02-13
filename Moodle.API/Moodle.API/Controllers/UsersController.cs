using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moodle.BLL.Services;
using Moodle.Domain.entities;
using Moodle.API.DTO;

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(UserService _userService) : ControllerBase
    {

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                List<Users> users = _userService.GetAllUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById([FromQuery] int id)
        {
            if (id == 0)
            {
                throw new ArgumentNullException("id");
            }

            Users? user = _userService.GetUserById(id);
            return Ok(user);
        }

        //Ajouter un user
        [HttpPost]
        public IActionResult AddUser([FromBody] UserDTO dto)
        {
            Users user = _userService.AddUser(dto.UserName, dto.Password, dto.Email, dto.Role);
            return Created("", new UserDTO(user));
        }

        //Delete un user
        [HttpDelete("{id}")]
        public IActionResult DeleteUser([FromQuery] int id)
        {
            try
            {
                _userService.Delete(id);
                return Ok();
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }


        //Update un user
        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute] int id, [FromBody] UserDTO dto)
        {
            try
            {
                _userService.UpdateUser(id, dto.UserName, dto.Email);
                return Ok();
            }
            catch(KeyNotFoundException)
            {
                return NotFound();
            }
        }
        // Voir le/les cour(s) d'un user
        // Voir les voila quoi ... 

    }
}
