using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students=new List<Student>();
        // GET: api/<StudentsController>
        [HttpGet]
            public  IEnumerable <Student> Get()
        {
               return _students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult <Student> Get(int id)
        {
            var stu =_students.Find(s=>s.Id == id);
            if(stu==null)
                return NotFound();
            else 
                return stu;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student student1)
        {
            _students.Add(new Student{Id=1,Name= student1.Name } );
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] string value)
        {
            var stu = _students.Find(s => s.Id == id);
            if (stu == null)
                return NotFound();
            else
            {
                stu.Name = value;
                return Ok();
            }
                
                
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var stu = _students.Find(s => s.Id == id);
            if (stu == null)
                return NotFound();
            else
            {
                _students.Remove(stu);
                return Ok();
            }
        }
    }
}
