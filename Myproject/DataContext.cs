using Myproject.Entities;

namespace Myproject
{
    public class DataContext
    {
        public  List<City> city { get; set; }
        public List<Course> _course { get; set; }
        public  List<Student> _students { get; set; }
        private int _idC;
        private int _idS;
        public DataContext()
        {
            _idC = 0;
            _idS = 0;
            city = new List<City>();
            city.Add(new City{ Name="Zichron",Count=7});
            _course = new List<Course>();
            _course.Add(new Course { Id = this._idC++, Name = "math" });
            _students = new List<Student>();
            _students.Add(new Student { Id = this._idS++, Name = "shira" });
        }
    }
}
