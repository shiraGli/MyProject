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
    }
}
