using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Servise
{
    public interface ICourseServise
    {
        List<Course> GetCourses();
        public Course AddCourse(Course course);

        public Course Update(int id, Course course);
        public void DeleteCourse(int id);

        public Course GetId(int id);
    }
}


