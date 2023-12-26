using Microsoft.AspNetCore.Mvc;
using Solid.Core;
using Solid.Core.Servise;
using Solid.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentServises _studentServises;
        private static int id = 0;
        public StudentsController(IStudentServises studentServises)
        {
            _studentServises = studentServises;
        }
        // GET: api/<StudentsController>
       
        [HttpGet]
            public ActionResult<Student> Get()
        {
            return Ok(_studentServises.GetStudents());
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult <Student> Get(int id)
        {
            var stu = _studentServises.GetStudents().Find(s=>s.Id == id);
            if(stu==null)
                return NotFound();
            else 
                return stu;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student student1)
        {
;            id++;
            _studentServises.GetStudents().Add(new Student{Id=id,Name= student1.Name } );
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] string value)
        {
            var stu = _studentServises.GetStudents().Find(s => s.Id == id);
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
            var stu = _studentServises.GetStudents().Find(s => s.Id == id);
            if (stu == null)
                return NotFound();
            else
            {
                _studentServises.GetStudents().Remove(stu);
                return Ok();
            }
        }
    }
}
