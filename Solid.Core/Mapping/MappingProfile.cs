using AutoMapper;
using Solid.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap(); 
            CreateMap<Login, LoginDto>().ReverseMap();


        }
    }
}
