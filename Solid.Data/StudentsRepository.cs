using Solid.Core.Repository;
using Solid.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    
    public class StudentsRepository:IStudentRepository
    {
        private readonly DataContext _context;
          public StudentsRepository(DataContext context)
        { 
            _context=context;
        }
        public List<Student> GetAllStudents()
        {
            
            return _context._students.ToList();
        }
        public Student AddStudent(Student student)
        {
            _context._students.Add(student);
            _context.SaveChanges();
            return student;

        }
        public Student GetId(int id)
        {
            var student = _context._students.Find(id);
            return student;
            
        }
        public Student Update(int id, Student student)
        {
            var studentChange = GetId(id);
            studentChange.Name = student.Name;
            _context.SaveChanges();
            return studentChange;
        }
        public void DeleteStudent(int id)
        {
            var student = _context._students.Find(id);
            _context._students.Remove(student);
            _context.SaveChanges();
        }
    }
}
