using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;
using Solid.Core;
using Solid.Core.DTOs;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServise _courseServise;
        private readonly IMapper _mapper;
        private static int id = 0;
        public CourseController(ICourseServise courseServise,IMapper mapper)
        {
            _courseServise = courseServise;
            _mapper = mapper;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public ActionResult<CourseDto> Get()
        {
            var list = _courseServise.GetCourses();
            var listDto = _mapper.Map<IEnumerable<CourseDto>>(list);
            return Ok(listDto);
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<CourseDto> Get(int id)
        {
            var course = _courseServise.GetId(id);
            var courseDto=_mapper.Map<CourseDto>(course);
            if (course == null)
                return NotFound();
            else
                return courseDto;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] CoursePostModel course1)
        {
             var userToAdd=_mapper.Map<Course>(course1); 
            _courseServise.AddCourse(userToAdd);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] Course course1)
        {

            var course = _courseServise.GetId(id);
            if (course == null)
                return NotFound();
            else
            {
                return Ok(_courseServise.Update(id,course1));
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public  ActionResult Delete(int id)
        {

            var course = _courseServise.GetId(id);
            if (course == null)
                return NotFound();
            else
            {
                _courseServise.DeleteCourse(id);
                return NoContent();
            }
        }
    }
}
