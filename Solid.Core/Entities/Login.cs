namespace Solid.Core
{
    public class Login
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        
        public Course Course { get; set; }

        public int CourseId { get; set; }   

    }
}
