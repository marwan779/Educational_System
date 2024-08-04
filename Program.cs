using Educational_System.CRUD;
using Educational_System.Models;

namespace Educational_System
{
    /// <summary>
    /// Main entry point for the Educational System application.
    /// Handles the user interface for managing students, teachers, courses, and enrollments.
    /// </summary>
    /// <author>Marwan Mohamed</author>
    /// <date>August 2024</date>
    public class Program
    {
        private static readonly EducationalSystemDbContext _context = new EducationalSystemDbContext();

        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Course course = new Course();

            while (true)
            {
                // Display main menu
                Console.WriteLine(" --------------------\n" +
                              "| Educational System |\n" +
                              " --------------------");
                Console.WriteLine("[1]Students Management\n[2]Teachers Management\n[3]Enrollments Management\n[4]Exit\n" +
                              "-------------------");
                Console.Write("Enter Your Choice: ");
                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    // Students management menu
                    Console.WriteLine(" --------------------\n" +
                                      "| Students Management |\n" +
                                      " --------------------");
                    Console.WriteLine("[1]Add New Student\n[2]Search For Student\n[3]Update Student\n[4]Delete Student\n[5]Print All Students\n" +
                                  "---------------------");
                    Console.Write("Enter Your Choice: ");
                    int StudentManage = int.Parse(Console.ReadLine());
                    switch (StudentManage)
                    {
                        case 1:
                            StudentManagement.AddNewStudent();
                            break;
                        case 2:
                            student = StudentManagement.SearchForStudent();
                            Console.WriteLine($"Name: {student.StudentName}\n" +
                                              $"ID: {student.StudentID}\n" +
                                              $"Department ID: {student.DepartmentID}" +
                                              $"\nEmail: {student.Email}" +
                                              $"\nAge {DateTime.Now.Year - student.DateOfBirth.Year}\nDate of Birth {student.DateOfBirth.ToShortDateString()}" +
                                              $"\nEnrollment Date: {student.EnrollmentDate.ToShortDateString()}");

                            break;
                        case 3:
                            StudentManagement.UpdateStudent();
                            break;
                        case 4:
                            StudentManagement.DeleteStudent();
                            break;
                        case 5:
                            StudentManagement.PrintAllStudents();
                            break;
                        default: throw new Exception("Enter Valid Choice !");

                    }
                }

                else if (Choice == 2)
                {
                    // Teachers management menu
                    Console.WriteLine(" ---------------------\n" +
                                      "| Teachers Management |\n" +
                                      " ---------------------");
                    Console.WriteLine("[1]Add New Teacher\n[2]Search For Teacher\n[3]Update Teacher\n[4]Delete Teacher\n[5]Print All Teachers\n" +
                                  "---------------------");
                    Console.Write("Enter Your Choice: ");
                    int TeacherManage = int.Parse(Console.ReadLine());
                    switch (TeacherManage)
                    {
                        case 1:
                            TeachersManagement.AddNewTeacher();
                            break;
                        case 2:
                            teacher = TeachersManagement.SearchForTeacher();
                            Console.WriteLine($"Name: {teacher.TeacherName}\n" +
                                              $"ID: {teacher.TeacherID}\n" +
                                              $"Department ID: {teacher.DepartmentID}" +
                                              $"\nEmail: {teacher.Email}\n" +
                                              $"Hire Date: {teacher.HireDate.ToShortDateString()}");

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
                            break;
                        case 3:
                            TeachersManagement.UpdateTeacher();
                            break;
                        case 4:
                            TeachersManagement.DeleteTeacher();
                            break;
                        case 5:
                            TeachersManagement.PrintAllTeachers();
                            break;
                        default: throw new Exception("Enter Valid Choice !");

                    }
                }

                else if (Choice == 3)
                {
                    // Enrollments management menu
                    Console.WriteLine(" ------------------------ \n" +
                                      "| Enrollments Management  |\n" +
                                      " ------------------------ ");
                    Console.WriteLine("[1]Add New Course\n" +
                                      "[2]Search For Course\n" +
                                      "[3]Update Course\n" +
                                      "[4]Print All Courses\n" +
                                      "[5]Add Course For Student\n" +
                                      "[6]Assign Course To Teacher\n" +
                                      "[7]View Student Enrollments\n" +
                                      "[8]Remove Course For Student\n" +
                                      "[9]Deassign Course From Teacher\n" +
                                      "---------------------");
                    Console.Write("Enter Your Choice: ");
                    int EnrollmentManage = int.Parse(Console.ReadLine());
                    Teacher teacher2 = new Teacher();
                    switch (EnrollmentManage)
                    {
                        case 1:
                            EnrollmentManagement.AddNewCourse();
                            break;
                        case 2:
                            course = EnrollmentManagement.SearchForCourse();
                            if (course.TeacherID != null)
                            {
                                teacher2 = _context.Teachers.Find(course.TeacherID);
                            }
                            Console.WriteLine($"Name: {course.CourseName}\n" +
                                              $"ID: {course.CourseID}\n" +
                                              $"Department ID: {course.DepartmentID}\n" +
                                              $"Credits: {course.Credits}\n" +
                                              $"Teacher: {teacher2.TeacherName}- {teacher2.TeacherID}");
                            break;
                        case 3:
                            EnrollmentManagement.UpdateCourse();
                            break;
                        case 4:
                            EnrollmentManagement.PrintAllCourse();
                            break;
                        case 5:
                            EnrollmentManagement.AddCourseForStudent(); 
                            break;
                        case 6:
                            EnrollmentManagement.AssignCourseToTeacher();
                            break;
                        case 7:
                            EnrollmentManagement.ViewStudentEnrollment();
                            break;
                        case 8:
                            EnrollmentManagement.RemoveEnrollment();
                            break;
                        case 9:
                            EnrollmentManagement.DeassignCourseFromTeacher();
                            break;
                        default:
                            Console.WriteLine("Enter Valid Choice");
                            break;

                    }
                }

                else if (Choice == 4)
                {
                    // Exit the application
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Choice !");
                }
            }
        }
    }
}
