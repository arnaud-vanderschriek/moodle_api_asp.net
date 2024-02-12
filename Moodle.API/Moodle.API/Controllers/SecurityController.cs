using Microsoft.AspNetCore.Mvc;
using Moodle.API.DTO;
using Moodle.BLL.Services;
using Moodle.Domain.entities;
using System.ComponentModel.DataAnnotations;
using BE.Arn.Security;

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController(SecurityService _securityService, BE.Arn.Security.JwtManager _jwtManager): ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginDTO dto)
        {
            try
            {
                Users U = _securityService.Login(dto.Username, dto.Password);
                string token = _jwtManager.CreateToken(U.UserName, U.Id.ToString());
                return Ok(new { Token = token });
            }
            catch(ValidationException)
            {
                return BadRequest("Invalid Credentials");
            }
        }
    }
}
