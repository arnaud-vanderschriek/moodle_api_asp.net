using Microsoft.AspNetCore.Mvc;
using Moodle.API.DTO;
using Moodle.API.DTO.Cursus;
using Moodle.BLL.Services;
using Moodle.Domain.entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursusController(CursusService _cursusService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Cursus> cursus = _cursusService.Get();
                return Ok(cursus);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            if(id == 0)
            {
                throw new ArgumentNullException("id");
            }

            Cursus cursus = _cursusService.Get(id);
            return Ok(cursus);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CursusFormDTO dto)
        {
            Cursus cursus = _cursusService.AddCursus(dto.Name, dto.startDate, dto.endDate);
            return Created("", new CursusDTO(cursus));
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

     
    }
}

