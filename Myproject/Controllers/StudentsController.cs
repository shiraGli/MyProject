using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private DataContext _dataContext;
        private static int id = 0;
        public StudentsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<StudentsController>
        [HttpGet]
            public  IEnumerable <Student> Get()
        {
               return _dataContext._students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult <Student> Get(int id)
        {
            var stu = _dataContext._students.Find(s=>s.Id == id);
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
            _dataContext._students.Add(new Student{Id=id,Name= student1.Name } );
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] string value)
        {
            var stu = _dataContext._students.Find(s => s.Id == id);
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
            var stu = _dataContext._students.Find(s => s.Id == id);
            if (stu == null)
                return NotFound();
            else
            {
                _dataContext._students.Remove(stu);
                return Ok();
            }
        }
    }
}
