namespace Educational_System.Models
{
    public class Teacher
    {
        // Unique identifier for the teacher
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public string Email { get; set; }

        // Foreign key for the department the teacher belongs to
        public int DepartmentID { get; set; }
        public DateTime HireDate { get; set; }

        public double Salary { get; set; }  

        // Navigation properties

        // The department to which the teacher belongs
        public Department Department { get; set; }

        // Collection of courses taught by the teacher
        public ICollection<Course> Courses { get; set; }

        // Constructor to initialize the Courses collection
        public Teacher()
        {
            Courses = new List<Course>();
        }
    }
}
