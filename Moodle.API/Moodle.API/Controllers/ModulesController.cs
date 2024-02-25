using Microsoft.AspNetCore.Mvc;
using Moodle.BLL.Services;
using Moodle.Domain.entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModulesController(ModuleService _moduleService) : ControllerBase
    {
        // GET: api/<ModulesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Module> modules = _moduleService.Get();
                return Ok(modules);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ModulesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ModulesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ModulesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ModulesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
