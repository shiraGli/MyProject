using AutoMapper;
using Myproject.Entities;
using Solid.Core;

namespace Myproject.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<CoursePostModel, Course>();
            CreateMap<StudentPostModel, Student>();
            CreateMap<LoginPostModel,Login>();
        }
    }
}
