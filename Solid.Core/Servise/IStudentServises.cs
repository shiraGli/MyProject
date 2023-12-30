using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface IStudentServises
    {
        public List<Student> GetStudents();
        public Student AddStudent(Student student);

        public Student Update(int id, Student student);
     
        public void DeleteStudent(int id);
        public Student GetId(int id);
    }
}
