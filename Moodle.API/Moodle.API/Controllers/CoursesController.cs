using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moodle.API.DTO.Courses;
using Moodle.BLL.Services;
using Moodle.Domain.entities;

namespace Moodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(CoursesService _coursesService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCourses()
        {
             List<Courses> courses = _coursesService.GetAll();
             return Ok(courses);
        }

        [HttpPost]
        public IActionResult AddCourses([FromForm] CoursesFormDTO dto)
        {
            Courses courses = _coursesService.Add(dto.Name, dto.Description, dto.startDate, dto.endDate);
            return Created("", new CoursesDTO(courses));
        }

         }
}
