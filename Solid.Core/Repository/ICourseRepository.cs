using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repository
{
    public interface ICourseRepository
    {
        public List<Course> GetAllCorse();
        public Course AddCourse(Course student);
        public Course Update(int id, Course student);
        public void DeleteCourse(int id);
        public Course GetId(int id);
    }
}
