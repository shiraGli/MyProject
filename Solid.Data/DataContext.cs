

using Microsoft.EntityFrameworkCore;
using Solid.Core;

namespace Solid.Data
{
    public class DataContext:DbContext
    {
      

        public DbSet<Login> login { get; set; }
        public DbSet<Course> _course { get; set; }
        public DbSet<Student> _students { get; set; }
        //private int _idC;
        //private int _idS;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=shirs_glick_db");
        }

        //public DataContext()
        // {
        //_idC = 0;
        //_idS = 0;
        //city = new List<City>();
        // city.Add(new City{ Name="Zichron",Count=7});
        //_course = new List<Course>();
        // _course.Add(new Course { Id = this._idC++, Name = "math" });
        // _students = new List<Student>();
        //     _students.Add(new Student { Id = this._idS++, Name = "shira" });
        // }
    }
}
