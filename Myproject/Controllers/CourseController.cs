using Microsoft.AspNetCore.Mvc;

using Solid.Core;
using Solid.Core.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourseServise _courseServise;
        private static int id = 0;
        public CourseController(ICourseServise courseServise)
        {
            _courseServise = courseServise;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public ActionResult<Course> Get()
        {
            return Ok(_courseServise.GetCourses());
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = _courseServise.GetId(id);
            if (course == null)
                return NotFound();
            else
                return course;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course1)
        {
           // id++;
            _courseServise.AddCourse(course1);
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
