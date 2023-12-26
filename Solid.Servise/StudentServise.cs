using Solid.Core.Repository;
using Solid.Core.Servise;
using Solid.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
  
    public class StudentServise:IStudentServises
    {
        public readonly IStudentRepository _StudentRepository;
        public StudentServise(IStudentRepository studentRepository)
        {
            _StudentRepository = studentRepository;  
        }
        public List<Student> GetStudents()
        {
            return _StudentRepository.GetAllStudents();
        }
    }
}

