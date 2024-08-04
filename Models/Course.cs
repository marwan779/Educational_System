namespace Educational_System.Models
{
    public class Course
    {
        // Unique identifier for the course
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        // Number of credit hours for the course
        public int Credits { get; set; }

        // Foreign key referencing the department to which the course belongs
        public int DepartmentID { get; set; }

        // Nullable foreign key referencing the teacher assigned to the course
        public int? TeacherID { get; set; }

        // Navigation property to the Department entity
        public Department Department { get; set; }

        // Navigation property to the Teacher entity
        public Teacher Teacher { get; set; }

        // Navigation property representing the collection of enrollments in the course
        public ICollection<Enrollment> Enrollments { get; set; }

        // Constructor to initialize the Enrollments collection
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
    }
}
