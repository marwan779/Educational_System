namespace Educational_System.Models
{
    public class Department
    {
        // Unique identifier for the department
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        // Navigation properties

        // Collection of students in the department
        public ICollection<Student> Students { get; set; }

        // Collection of teachers in the department
        public ICollection<Teacher> Teachers { get; set; }

        // Collection of courses offered by the department
        public ICollection<Course> Courses { get; set; }

        // Constructor to initialize the collections to avoid null reference exceptions
        public Department()
        {
            Students = new List<Student>();
            Teachers = new List<Teacher>();
            Courses = new List<Course>();
        }
    }
}
