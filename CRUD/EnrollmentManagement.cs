using Educational_System.Models;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace Educational_System.CRUD
{
    /// <summary>
    /// Provides CRUD operations for managing courses and enrollments in the Educational System.
    /// </summary>
    public class EnrollmentManagement
    {
        private static readonly EducationalSystemDbContext _context = new EducationalSystemDbContext();

        /// <summary>
        /// Adds a new course to the database.
        /// Prompts the user for course details and validates input.
        /// </summary>
        public static void AddNewCourse()
        {
            Course course = new Course();

            Console.Write("Enter Course Name: ");
            course.CourseName = Console.ReadLine();

            // Display available departments
            var departments = _context.Departments.Select(e => e);
            foreach (var department in departments)
            {
                Console.WriteLine($"{department.DepartmentName}- {department.DepartmentID}");
            }

            Console.Write("Enter Course Department ID: ");
            course.DepartmentID = int.Parse(Console.ReadLine());

            Console.Write("Enter Course Credits: ");
            course.Credits = int.Parse(Console.ReadLine());

            // Add the course to the context and save changes
            _context.Courses.Add(course);
            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Course Added Successfully (Course ID: {course.CourseID})");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Searches for a course by ID.
        /// </summary>
        /// <returns>The found course object.</returns>
        /// <exception cref="Exception">Thrown if the course is not found.</exception>
        public static Course SearchForCourse()
        {
            Console.Write("Enter Course ID: ");
            int ID = int.Parse(Console.ReadLine());

            Course course = _context.Courses.Find(ID);
            if (course != null)
            {
                return course;
            }
            else
            {
                throw new Exception("Course Not Found");
            }
        }

        /// <summary>
        /// Updates the details of an existing course.
        /// Prompts the user for new course details and validates input.
        /// </summary>
        public static void UpdateCourse()
        {
            Course course = SearchForCourse(); // Retrieve course details
            Helpers.PrintCourse(course);
            
            Console.Write("\nEnter Course New Name: ");
            course.CourseName = Console.ReadLine();

            Console.Write("Enter Course New Department ID: ");
            course.DepartmentID = int.Parse(Console.ReadLine());

            Console.Write("Enter Course New Credits: ");
            course.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Display available teachers
            var teachers = _context.Teachers.Select(e => e);
            foreach (var t in teachers)
            {
                Console.WriteLine($"Teacher: {t.TeacherName}- ID: {t.TeacherID}- Department ID {t.DepartmentID}");
            }

            Console.Write("Enter Course New Teacher ID: ");
            course.TeacherID = int.Parse(Console.ReadLine());

            // Update course details and save changes
            _context.Update(course);
            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Course Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
        }

        

        /// <summary>
        /// Adds a course for a specific student.
        /// </summary>
        public static void AddCourseForStudent()
        {
            Student student = StudentManagement.SearchForStudent();
            Course course = SearchForCourse();
            Enrollment enrollment = new Enrollment
            {
                StudentID = student.StudentID,
                CourseID = course.CourseID
            };

            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Course is Added For Student Successfully");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Assigns a course to a specific teacher.
        /// </summary>
        public static void AssignCourseToTeacher()
        {
            Teacher teacher = TeachersManagement.SearchForTeacher();
            Course course = SearchForCourse();

            course.TeacherID = teacher.TeacherID;

            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Course is Assigned Successfully");
            Console.ForegroundColor = ConsoleColor.Green;
        }

        /// <summary>
        /// Views all courses enrolled by a specific student.
        /// </summary>
        public static void ViewStudentEnrollment()
        {
            Student student = StudentManagement.SearchForStudent();
            var studentEnrollments = _context.Enrollments.Where(e => e.StudentID == student.StudentID).ToList();
            if (!studentEnrollments.Any())
            {
                Console.WriteLine("No Enrollments Found For This Student.");
                return;
            }

            Console.WriteLine($"Name: {student.StudentName}\nID: {student.StudentID}");
            Console.WriteLine("--------Courses--------");
            foreach (var enrollment in studentEnrollments)
            {
                var course = _context.Courses.FirstOrDefault(c => c.CourseID == enrollment.CourseID);
                if (course != null)
                {
                    Console.WriteLine($"Name: {course.CourseName}\n" +
                                      $"ID: {course.CourseID}\n" +
                                      $"Department ID: {course.DepartmentID}\n" +
                                      $"Credits: {course.Credits}\n");
                }
            }
        }

        /// <summary>
        /// Removes a specific enrollment from a student.
        /// Prompts the user for confirmation before removing.
        /// </summary>
        public static void RemoveEnrollment()
        {
            Student student = StudentManagement.SearchForStudent();
            var studentEnrollments = _context.Enrollments.Where(e => e.StudentID == student.StudentID).ToList();

            // Display all enrollments for the student
            foreach (var enrollment in studentEnrollments)
            {
                var course = _context.Courses.FirstOrDefault(c => c.CourseID == enrollment.CourseID);
                if (course != null)
                {
                    Console.WriteLine($"Course ID: {course.CourseID}, Course Name: {course.CourseName}");
                }
            }

            Console.Write("Enter the Course ID of the enrollment you want to remove: ");
            int courseId = int.Parse(Console.ReadLine());
            var enrollmentToRemove = studentEnrollments.FirstOrDefault(e => e.CourseID == courseId);
            if (enrollmentToRemove == null)
            {
                Console.WriteLine("No enrollment found with the specified Course ID.");
                return;
            }

            Console.Write($"Are you sure you want to remove this enrollment? (y/n): ");
            char confirmation = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (confirmation == 'y')
            {
                _context.Enrollments.Remove(enrollmentToRemove);
                _context.SaveChanges();
                Console.WriteLine("Enrollment removed successfully.");
            }
            else
            {
                Console.WriteLine("Enrollment removal cancelled.");
            }
        }

        /// <summary>
        /// Deassigns a course from its current teacher.
        /// </summary>
        public static void DeassignCourseFromTeacher()
        {
            Course course = SearchForCourse();
            if (course.TeacherID != null)
            {
                course.TeacherID = null;
                _context.Update(course);
                _context.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Course Has Been Successfully Deassigned");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("The Course Is Already Deassigned");
            }
        }

        /// <summary>
        /// Assign a course score for a student.
        /// </summary>
        public static void AssignScoreToStudent()
        {
            Student student = StudentManagement.SearchForStudent();
            var StudentEnrollments = _context.Enrollments.Where(s => s.StudentID == student.StudentID).ToList(); 

            foreach(var enroll in StudentEnrollments)
            {
                var course = _context.Courses.Find(enroll.CourseID);
                Console.Write($"Enter the score for [{course.CourseName}] (between 0 and 100): ");
                enroll.score = double.Parse(Console.ReadLine());
                if(enroll.score < 0 || enroll.score > 100)
                {
                    throw new Exception("Enter a Vaild Score");
                }
            }


            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Scores have been assigned successfully.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
