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
        public Student AddStudent(Student student)
        {
            return _StudentRepository.AddStudent(student);
        }

        public Student Update(int id, Student student)
        {
            return _StudentRepository.Update(id, student);
        }
        public void DeleteStudent(int id)
        {
            _StudentRepository.DeleteStudent(id);
        }
        public Student GetId(int id)
        {
            return _StudentRepository.GetId(id);
        }


    }
}

