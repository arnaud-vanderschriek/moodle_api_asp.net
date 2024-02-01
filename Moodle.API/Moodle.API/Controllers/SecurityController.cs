using Be.Khunly.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle.API.DTO;
using Moodle.BLL.Services;
using Moodle.Domain.entities;
using System.ComponentModel.DataAnnotations;

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController(SecurityService _securityService, JwtManager _jwtManager): ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            try
            {
                Login L = _securityService.Login(dto.Email, dto.Password);
                string token = _jwtManager.CreateToken(L.Email, L.Id.ToString(), L.Email, L.Role);
                return Ok(new { Token = token });
            }
            catch(ValidationException)
            {
                return BadRequest("Invalid Credentials");
            }
        }
    }
}
