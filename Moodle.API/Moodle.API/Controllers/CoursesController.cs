using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle.BLL.Services;
using Moodle.Domain.entities;

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(CoursesService coursesService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourses()
        {
            try
            {
                List<Courses> courses = coursesService.GetAll();
                return Ok(courses);
            }
        }
    }
}
