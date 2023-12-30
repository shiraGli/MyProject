using Solid.Core;
using Solid.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class CourseRepository:ICourseRepository
    {
        private readonly DataContext _context;
        public CourseRepository(DataContext context)
        {
            _context = context;
        }
        public List<Course> GetAllCorse()
        {
            return _context._course.ToList();
        }
        public Course AddCourse(Course course)
        {
            _context._course.Add(course);
            _context.SaveChanges();
            return course;

        }
       
        public Course GetId(int id)
        {
            var course = _context._course.Find(id);
            return course;
        }
        public Course Update(int id, Course course)
        {
            var courseChange = GetId(id);
            courseChange.Name = course.Name;
            _context.SaveChanges();
            return courseChange;
        }
        public void DeleteCourse(int id)
        {
            var course = _context._course.Find(id);
            _context._course.Remove(course);
            _context.SaveChanges();
        }
    }
}
