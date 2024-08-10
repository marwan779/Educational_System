namespace Educational_System.Models
{
    public class Student
    {
        // Unique identifier for the student
        public int StudentID { get; set; }

        public string StudentName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public string Email { get; set; }

        public double AverageScore { get; set; }

        // Foreign key for the department the student belongs to
        public int DepartmentID { get; set; }

        // Navigation properties

        // The department to which the student belongs
        public Department Department { get; set; }

        // Collection of enrollments associated with the student
        public ICollection<Enrollment> Enrollments { get; set; }

        // Constructor to initialize the Enrollments collection
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
    }
}
