using Educational_System.Models;


namespace Educational_System
{
    public class Helpers
    {
        private static readonly EducationalSystemDbContext _context = new EducationalSystemDbContext();

        /// <summary>
        /// Prints the details of a given student, including their average score.
        /// </summary>
        /// <param name="student">The student object whose details are to be printed.</param>
        public static void PrintStudent(Student student)
        {
            student.AverageScore = CalculateAverageScoreForStudnet(student);

            Console.WriteLine($"Name: {student.StudentName}\n" +
                                              $"ID: {student.StudentID}\n" +
                                              $"Department ID: {student.DepartmentID}\n" +
                                              $"Email: {student.Email} \n" +
                                              $"Age {DateTime.Now.Year - student.DateOfBirth.Year}\nDate of Birth {student.DateOfBirth.ToShortDateString()}\n" +
                                              $"Enrollment Date: {student.EnrollmentDate.ToShortDateString()}\n" +
                                              $"Average Score: {student.AverageScore}");
        }

        /// <summary>
        /// Calculates the average score for a given student based on their enrollments.
        /// </summary>
        /// <param name="student">The student object for whom the average score is to be calculated.</param>
        /// <returns>The average score of the student.</returns>
        public static double CalculateAverageScoreForStudnet(Student student)
        {
            var StudentEnrollments = _context.Enrollments.Where(s => s.StudentID == student.StudentID).ToList();
            double average = StudentEnrollments.Average(e =>e.score).GetValueOrDefault();
            return average;
        }

        // <summary>
        /// Prints the details of a given teacher, including the courses they are assigned to.
        /// </summary>
        /// <param name="teacher">The teacher object whose details are to be printed.</param>
        public static void PrintTeacher(Teacher teacher)
        {
            Console.WriteLine($"Name: {teacher.TeacherName}\n" +
                                              $"ID: {teacher.TeacherID}\n" +
                                              $"Department ID: {teacher.DepartmentID}\n" +
                                              $"Email: {teacher.Email}\n" +
                                              $"Hire Date: {teacher.HireDate.ToShortDateString()}\n" +
                                              $"Salary: {teacher.Salary}$");

            // Fetch and display courses assigned to the teacher
            var courses = from course1 in _context.Courses
                          join teacher1 in _context.Teachers
                          on course1.TeacherID equals teacher.TeacherID
                          where teacher1.TeacherID == teacher.TeacherID
                          select new
                          {
                              CourseName = course1.CourseName,
                              CourseID = course1.CourseID,
                          };
            Console.WriteLine($"Courses assigned to Teacher ID {teacher.TeacherID}:");
            foreach (var c in courses)
            {
                Console.WriteLine($"Course ID: {c.CourseID}, Course Name: {c.CourseName}");
            }
        }

        /// <summary>
        /// Prints the details of a given course, including the assigned teacher's name.
        /// </summary>
        /// <param name="course">The course object whose details are to be printed.</param>
        public static void PrintCourse(Course course)
        {
            Teacher teacher = new Teacher();
            if (course.TeacherID != null)
            {
                teacher = _context.Teachers.Find(course.TeacherID);
            }
            Console.WriteLine($"Name: {course.CourseName}\n" +
                              $"ID: {course.CourseID}\n" +
                              $"Department ID: {course.DepartmentID}\n" +
                              $"Credits: {course.Credits}\n" +
                              $"Teacher: {teacher.TeacherName}- {teacher.TeacherID}");
        }
    }
}
