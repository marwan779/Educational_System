using System.Diagnostics.Contracts;

namespace Educational_System.Models
{
    public class Enrollment
    {
        // Foreign key for the student who is enrolled
        public int StudentID { get; set; }

        // Foreign key for the course in which the student is enrolled
        public int CourseID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // the score of the course 
        public double? score { get; set; }
   
        // Navigation properties

        // The student who is enrolled in the course
        public Student Student { get; set; }

        // The course in which the student is enrolled
        public Course Course { get; set; }
    }
}
