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
                                      "[10]Assign Score To Student\n" +
                                      "---------------------");
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
