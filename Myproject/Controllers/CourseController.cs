using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private static List<Course> _course = new List<Course>();
        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _course;
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public ActionResult<Course> Get(int id)
        {
            var course = _course.Find(s => s.Id == id);
            if (course == null)
                return NotFound();
            else
                return course;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Course course1)
        {
            _course.Add(new Course { Id = 1, Name = course1.Name });
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] string value)
        {

            var course = _course.Find(s => s.Id == id);
            if (course == null)
                return NotFound();
            else
            {
                course.Name = value;
                return Ok();
            }
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public  ActionResult Delete(int id)
        {

            var course = _course.Find(s => s.Id == id);
            if (course == null)
                return NotFound();
            else
            {
                _course.Remove(course);
                return Ok();
            }
        }
    }
}
