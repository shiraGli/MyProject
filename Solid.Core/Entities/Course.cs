namespace Solid.Core
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public List<Student> Student { get; set; }
        //public int StudentId { get; set; }
        public List<Login> Login { get; set; }
    }
}
