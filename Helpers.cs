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
            Console.WriteLine("\n");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+----------------+-----------------+---------------+");
            Console.WriteLine("| ID |             Name                | Department ID  |             Email              |      Age       | Enrollment Date | Average Score |");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+----------------+-----------------+---------------+");
            Console.WriteLine($"|{student.StudentID,2}  | {student.StudentName,-31} | {student.DepartmentID,8}       | {student.Email,-30} | {DateTime.Now.Year - student.DateOfBirth.Year ,8}       | " +
                $" {student.EnrollmentDate.ToShortDateString(),10}     | {student.AverageScore,8}      |");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+----------------+-----------------+---------------+");
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Prints all students in the database.
        /// </summary>
        public static void PrintAllStudents()
        {
            var students = _context.Students.ToList();
            Console.WriteLine("\n");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+----------------+-----------------+---------------+");
            Console.WriteLine("| ID |             Name                | Department ID  |             Email              |      Age       | Enrollment Date | Average Score |");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+----------------+-----------------+---------------+");
            foreach (Student student in students)
            {
                student.AverageScore = CalculateAverageScoreForStudnet(student);

                Console.WriteLine($"|{student.StudentID,2}  | {student.StudentName,-31} | {student.DepartmentID,8}       | {student.Email,-30} | {DateTime.Now.Year - student.DateOfBirth.Year,8}       | " +
                $" {student.EnrollmentDate.ToShortDateString(),10}     | {student.AverageScore,8}      |");
                Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+----------------+-----------------+---------------+");
            }
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+---------------------+--------+");
            Console.WriteLine("| ID |             Name                | Department ID  |             Email              |      Hire Date      | Salary | ");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+---------------------+--------+");
            Console.WriteLine($"|{teacher.TeacherID,2}  | {teacher.TeacherName,-31} | {teacher.DepartmentID,8}       | {teacher.Email,-30} | {teacher.HireDate.ToShortDateString(),13}       | " +
               $" {teacher.Salary,2} |");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+---------------------+--------+");
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Prints all teachers in the database.
        /// </summary>
        public static void PrintAllTeachers()
        {
            var teachers = _context.Teachers.ToList();
            Console.WriteLine("\n");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+---------------------+--------+");
            Console.WriteLine("| ID |             Name                | Department ID  |             Email              |      Hire Date      | Salary | ");
            Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+---------------------+--------+");

            foreach (var teacher in teachers)
            {
                Console.WriteLine($"|{teacher.TeacherID,2}  | {teacher.TeacherName,-31} | {teacher.DepartmentID,8}       | {teacher.Email,-30} | {teacher.HireDate.ToShortDateString(),13}       | " +
                   $" {teacher.Salary,2} |");
                Console.WriteLine("+----+---------------------------------+----------------+--------------------------------+---------------------+--------+");

            }
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
            Console.WriteLine("+----+---------------------------------+----------------+---------+------------+---------------------------------+");
            Console.WriteLine("| ID |             Title               | Department ID  | Credits | Teacher ID |          Teacher Name           | ");
            Console.WriteLine("+----+---------------------------------+----------------+---------+------------+---------------------------------+");

            Console.WriteLine($"|{course.CourseID,2}  | {course.CourseName,-31} | {course.DepartmentID,8}       | {course.Credits,-7} | {teacher.TeacherID,-7}    |{teacher.TeacherName,+20}             | ");
            Console.WriteLine("+----+---------------------------------+----------------+---------+------------+---------------------------------+");
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Prints all courses in the database.
        /// </summary>
        public static void PrintAllCourse()
        {
            Teacher teacher = new Teacher();
            var teachers = _context.Teachers.ToList();
            Console.WriteLine("\n");
            Console.WriteLine("+----+---------------------------------+----------------+---------+------------+---------------------------------+");
            Console.WriteLine("| ID |             Title               | Department ID  | Credits | Teacher ID |          Teacher Name           | ");
            Console.WriteLine("+----+---------------------------------+----------------+---------+------------+---------------------------------+");

            foreach(Course course in _context.Courses)
            {
                if (course.TeacherID != null)
                {
                    teacher = teachers.Find(t => t.TeacherID == course.TeacherID);
                }
                else
                {
                    teacher.TeacherName = "";
                    teacher.TeacherID = 0;
                }

                Console.WriteLine($"|{course.CourseID,2}  | {course.CourseName,-31} | {course.DepartmentID,8}       | {course.Credits,-7} | {teacher.TeacherID,-7}    |{teacher.TeacherName,+20}             | ");
                Console.WriteLine("+----+---------------------------------+----------------+---------+------------+---------------------------------+");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Prints all Departments in the database.
        /// </summary>
        public static void PrintAllDepartments()
        {
            var Departments = _context.Departments.ToList();
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("| Department ID | Department Name          |");
            Console.WriteLine("--------------------------------------------");
            foreach(var department in Departments)
            {
                Console.WriteLine($"|       {department.DepartmentID}       | {department.DepartmentName}");
            }

            Console.WriteLine("+---------------+--------------------------+");
            Console.WriteLine("\n");

        }
    }
}
