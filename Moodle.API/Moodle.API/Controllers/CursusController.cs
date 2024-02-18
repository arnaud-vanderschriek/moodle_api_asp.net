using Microsoft.AspNetCore.Mvc;
using Moodle.BLL.Services;
using Moodle.Domain.entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursusController(CursusService _cursusService) : ControllerBase
    {
        // GET: api/<CursusController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Cursus> cursus = _cursusService.Get();
            return Ok(cursus);
        }

        // GET api/<CursusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CursusController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CursusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CursusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
