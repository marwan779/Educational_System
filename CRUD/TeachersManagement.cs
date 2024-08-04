using Educational_System.Models;

namespace Educational_System.CRUD
{
    /// <summary>
    /// Provides CRUD operations for managing teachers in the Educational System.
    /// </summary>
    public class TeachersManagement
    {
        private static readonly EducationalSystemDbContext _context = new EducationalSystemDbContext();

        /// <summary>
        /// Adds a new teacher to the database.
        /// Prompts the user for teacher details and validates input.
        /// </summary>
        public static void AddNewTeacher()
        {
            Teacher teacher = new Teacher();

            Console.Write("Enter Teacher Name: ");
            teacher.TeacherName = Console.ReadLine();

            // Display available departments
            var departments = _context.Departments.Select(e => e);
            foreach (var department in departments)
            {
                Console.WriteLine($"Department Name: {department.DepartmentName} Department ID: {department.DepartmentID}");
            }

            Console.Write("Enter Teacher Department ID: ");
            teacher.DepartmentID = int.Parse(Console.ReadLine());

            Console.Write("Enter Teacher Email (must contain @): ");
            teacher.Email = Console.ReadLine();
            if (String.IsNullOrEmpty(teacher.Email) || !teacher.Email.Contains('@'))
            {
                throw new Exception("Enter a Valid Email!");
            }

            _context.Add(teacher);
            _context.SaveChanges();

            Console.WriteLine($"Teacher Added Successfully (Teacher ID {teacher.TeacherID})");
        }

        /// <summary>
        /// Searches for a teacher by ID.
        /// </summary>
        /// <returns>The found teacher object.</returns>
        /// <exception cref="Exception">Thrown if the teacher is not found.</exception>
        public static Teacher SearchForTeacher()
        {
            Console.Write("Enter Teacher ID: ");
            int ID = int.Parse(Console.ReadLine());

            Teacher teacher = _context.Teachers.Find(ID);
            if (teacher != null)
            {
                return teacher;
            }
            else
            {
                throw new Exception("Teacher Not Found");
            }
        }

        /// <summary>
        /// Updates the details of an existing teacher.
        /// Prompts the user for new teacher details and validates input.
        /// </summary>
        public static void UpdateTeacher()
        {
            Teacher teacher = SearchForTeacher();

            Console.WriteLine("The Old Data");
            Console.WriteLine();
            Console.WriteLine($"Name: {teacher.TeacherName}\nID: {teacher.TeacherID}\nDepartment ID: {teacher.DepartmentID}\nEmail: {teacher.Email}\nHire Date: {teacher.HireDate.ToShortDateString()}");

            Console.Write("Enter Teacher New Name: ");
            teacher.TeacherName = Console.ReadLine();

            Console.Write("Enter Teacher New Department ID:");
            teacher.DepartmentID = int.Parse(Console.ReadLine());

            Console.Write("Enter Teacher New Email (must contain @): ");
            teacher.Email = Console.ReadLine();
            if (String.IsNullOrEmpty(teacher.Email) || !teacher.Email.Contains('@'))
            {
                throw new Exception("Enter a Valid Email!");
            }

            _context.Update(teacher);
            _context.SaveChanges();
            Console.WriteLine($"Teacher Updated Successfully");
        }

        /// <summary>
        /// Deletes a teacher from the database.
        /// Prompts the user for confirmation before deletion.
        /// </summary>
        public static void DeleteTeacher()
        {
            Teacher teacher = SearchForTeacher();

            Console.WriteLine($"Name: {teacher.TeacherName}\nID: {teacher.TeacherID}\nDepartment ID: {teacher.DepartmentID}\nEmail: {teacher.Email}\nHire Date: {teacher.HireDate.ToShortDateString()}");
            Console.Write("Are you sure you want to delete this teacher? (y/n): ");
            char sure = char.Parse(Console.ReadLine());
            sure = Char.ToLower(sure);
            if (sure == 'y')
            {
                var courses = _context.Courses.Where(c => c.TeacherID == teacher.TeacherID).ToList();
                foreach (var course in courses)
                {
                    course.TeacherID = null;
                }
                _context.SaveChanges();

                _context.Remove(teacher);
                _context.SaveChanges();
                Console.WriteLine("Teacher Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Deletion Cancelled");
            }
        }

        /// <summary>
        /// Prints all teachers in the database.
        /// </summary>
        public static void PrintAllTeachers()
        {
            var teachers = _context.Teachers.ToList();

            foreach (var teacher in teachers)
            {
                Console.WriteLine($"Name: {teacher.TeacherName}\nID: {teacher.TeacherID}\nDepartment ID: {teacher.DepartmentID}\nEmail: {teacher.Email}\nHire Date: {teacher.HireDate.ToShortDateString()}");
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
