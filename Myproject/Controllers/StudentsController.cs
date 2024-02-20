using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Myproject.Entities;
using Solid.Core;
using Solid.Core.DTOs;
using Solid.Core.Servise;
using Solid.Servise;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Myproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentServises _studentServises;
        private readonly IMapper _mapper;
        private static int id = 0;
        public StudentsController(IStudentServises studentServises, IMapper mapper)
        {
            _studentServises = studentServises;
            _mapper = mapper;   
        }
        // GET: api/<StudentsController>
       
        [HttpGet]
            public ActionResult<StudentDto> Get()
        {
            var list = _studentServises.GetStudents();
            var listDto=_mapper.Map<IEnumerable<StudentDto>>(list);
            return Ok(listDto);
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult <StudentDto> Get(int id)
        {
            var stu = _studentServises.GetId(id);
            var studentDto = _mapper.Map<StudentDto>(stu);
            if(stu==null)
                return NotFound();
            else 
                return studentDto;
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] StudentPostModel student1)
        {
;           var StudentToAdd=_mapper.Map<Student>(student1);
            _studentServises.AddStudent(StudentToAdd);
        }
        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public ActionResult  Put(int id, [FromBody] Student student)
        {
            var stu = _studentServises.GetId(id);
            if (stu == null)
                return NotFound();
            else
            {

                return Ok(_studentServises.Update(id,student));
            }
                
                
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var stu = _studentServises.GetId(id);
            if (stu == null)
                return NotFound();
            else
            {
                _studentServises.DeleteStudent(id);
                return Ok();
            }
        }
    }
}
