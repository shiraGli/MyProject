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
    }
}
