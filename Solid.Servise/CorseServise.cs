using Solid.Core;
using Solid.Core.Repository;
using Solid.Core.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Servise
{
    public class CorseServise :ICourseServise
    {
        private readonly ICourseRepository _courseRepository;
        public CorseServise(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public List<Course> GetCourses()
        {
            return _courseRepository.GetAllCorse();
        }
        public Course AddCourse(Course course)
        {
            return _courseRepository.AddCourse(course);
        }
        
             public Course Update(int id, Course course)
        {
            return _courseRepository.Update(id, course);
        }
            public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }
        public Course GetId(int id)
        {
            return _courseRepository.GetId(id);
        }
    }
}
