namespace Solid.Core
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Login Login { get; set; }

        // public int CourseId { get; set; }
        public List<Course> Course { get; set; }
       
    }
}
