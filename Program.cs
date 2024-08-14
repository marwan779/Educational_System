using Educational_System.CRUD;
using Educational_System.Models;
using System;

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
                Console.WriteLine("╔════════════════════════╗");
                Console.WriteLine("║   Educational System   ║");
                Console.WriteLine("╚════════════════════════╝");
                Console.WriteLine("╔═══════════════════════════╗");
                Console.WriteLine("║ [1] Students Management   ║");
                Console.WriteLine("║ [2] Teachers Management   ║");
                Console.WriteLine("║ [3] Enrollments Management║");
                Console.WriteLine("║ [4] Exit                  ║");
                Console.WriteLine("╚═══════════════════════════╝");
                Console.Write("Enter Your Choice: ");
                int Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    // Students management menu
                    Console.WriteLine("╔══════════════════════╗");
                    Console.WriteLine("║  Students Management ║");
                    Console.WriteLine("╚══════════════════════╝");

                    Console.WriteLine("╔═══════════════════════╗");
                    Console.WriteLine("║ [1] Add New Student   ║");
                    Console.WriteLine("║ [2] Search for Student║");
                    Console.WriteLine("║ [3] Update Student    ║");
                    Console.WriteLine("║ [4] Delete Student    ║");
                    Console.WriteLine("║ [5] Print All Students║");
                    Console.WriteLine("╚═══════════════════════╝");

                    Console.Write("Enter Your Choice: ");
                    int StudentManage = int.Parse(Console.ReadLine());
                    switch (StudentManage)
                    {
                        case 1:
                            StudentManagement.AddNewStudent();
                            break;
                        case 2:
                            student = StudentManagement.SearchForStudent();
                            Helpers.PrintStudent(student);

                            break;
                        case 3:
                            StudentManagement.UpdateStudent();
                            break;
                        case 4:
                            StudentManagement.DeleteStudent();
                            break;
                        case 5:
                            Helpers.PrintAllStudents(); 
                            break;
                        default: throw new Exception("Enter Valid Choice !");

                    }
                }

                else if (Choice == 2)
                {
                    // Teachers management menu
                    Console.WriteLine("╔═════════════════════╗");
                    Console.WriteLine("║ Teachers Management ║");
                    Console.WriteLine("╚═════════════════════╝");
                    Console.WriteLine("╔═══════════════════════╗");
                    Console.WriteLine("║ [1] Add New Teacher   ║");
                    Console.WriteLine("║ [2] Search for Teacher║");
                    Console.WriteLine("║ [3] Update Teacher    ║");
                    Console.WriteLine("║ [4] Delete Teacher    ║");
                    Console.WriteLine("║ [5] Print All Teachers║");
                    Console.WriteLine("╚═══════════════════════╝");
                    Console.Write("Enter Your Choice: ");
                    int TeacherManage = int.Parse(Console.ReadLine());
                    switch (TeacherManage)
                    {
                        case 1:
                            TeachersManagement.AddNewTeacher();
                            break;
                        case 2:
                            teacher = TeachersManagement.SearchForTeacher();
                            Helpers.PrintTeacher(teacher);
                            break;
                        case 3:
                            TeachersManagement.UpdateTeacher();
                            break;
                        case 4:
                            TeachersManagement.DeleteTeacher();
                            break;
                        case 5:
                            Helpers.PrintAllTeachers();
                            break;
                        default: throw new Exception("Enter Valid Choice !");

                    }
                }

                else if (Choice == 3)
                {
                    // Enrollments management menu
                    Console.WriteLine("╔═════════════════════════╗");
                    Console.WriteLine("║  Enrollments Management ║");
                    Console.WriteLine("╚═════════════════════════╝");

                    Console.WriteLine("╔═════════════════════════════════╗");
                    Console.WriteLine("║ [1] Add New Course              ║");
                    Console.WriteLine("║ [2] Search for Course           ║");
                    Console.WriteLine("║ [3] Update Course               ║");
                    Console.WriteLine("║ [4] Print All Courses           ║");
                    Console.WriteLine("║ [5] Add Course for Student      ║");
                    Console.WriteLine("║ [6] Assign Course to Teacher    ║");
                    Console.WriteLine("║ [7] View Student Enrollments    ║");
                    Console.WriteLine("║ [8] Remove Course for Student   ║");
                    Console.WriteLine("║ [9] Deassign Course from Teacher║");
                    Console.WriteLine("║ [10] Assign Score to Student    ║");
                    Console.WriteLine("╚═════════════════════════════════╝");
                    Console.Write("Enter Your Choice: ");
                    int EnrollmentManage = int.Parse(Console.ReadLine());
   
                    switch (EnrollmentManage)
                    {
                        case 1:
                            EnrollmentManagement.AddNewCourse();
                            break;
                        case 2:
                            course = EnrollmentManagement.SearchForCourse();
                            Helpers.PrintCourse(course);
                            break;
                        case 3:
                            EnrollmentManagement.UpdateCourse();
                            break;
                        case 4:
                            Helpers.PrintAllCourse();
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
                        case 10:
                            EnrollmentManagement.AssignScoreToStudent();                            
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
