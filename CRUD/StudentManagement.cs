using Educational_System.Models;

namespace Educational_System.CRUD
{
    /// <summary>
    /// Provides CRUD operations for managing students in the Educational System.
    /// </summary>
    public class StudentManagement
    {
        private static readonly EducationalSystemDbContext _context = new EducationalSystemDbContext();

        /// <summary>
        /// Adds a new student to the database.
        /// Prompts the user for student details and validates input.
        /// </summary>
        public static void AddNewStudent()
        {
            Student student = new Student();

            // Prompt user for student details
            Console.Write("Enter Student Full Name: ");
            student.StudentName = Console.ReadLine();

            Console.WriteLine();

            // Display available departments
            Helpers.PrintAllDepartments();

            Console.Write("Enter Student Department ID: ");
            student.DepartmentID = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Birth Date (yyyy-mm-dd): ");
            student.DateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Student Email (the email must contain @): ");
            string email = Console.ReadLine();

            var UniqeEmail = _context.Students.FirstOrDefault(student => student.Email == email);

            // Validate email input
            if (String.IsNullOrEmpty(email) || !email.Contains('@'))
            { 
                throw new Exception("Enter a Valid Email!");
            }
            else if(UniqeEmail != null)
            {
                throw new Exception("A student with this email already exists. Please use a different email.");
            }
            else
            {
                student.Email = email;
            }

            // Add the student to the context and save changes
            _context.Add(student);
            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Student Added Successfully (Student ID: {student.StudentID})");
            Console.ForegroundColor= ConsoleColor.White;
        }

        /// <summary>
        /// Searches for a student by ID.
        /// </summary>
        /// <returns>The found student object.</returns>
        /// <exception cref="Exception">Thrown if the student is not found.</exception>
        public static Student SearchForStudent()
        {
            Console.Write("Enter Student ID: ");
            int ID = int.Parse(Console.ReadLine());
            var search = _context.Students.Find(ID);

            
            if (search != null)
            {
                return search;
            }
            else
            {
                throw new Exception("Student Not Found");
            }
        }

        /// <summary>
        /// Updates the details of an existing student.
        /// Prompts the user for new student details and validates input.
        /// </summary>
        public static void UpdateStudent()
        {
            Student search = SearchForStudent(); // Retrieve student details
            Console.WriteLine("The Old Data");
            Console.WriteLine();
            Helpers.PrintStudent(search);
            Console.WriteLine();

            // Prompt user for new student details
            Console.Write("Enter Student New Name (Press Enter To Skip): ");
            string TempName = Console.ReadLine();

            if(!String.IsNullOrEmpty(TempName))
            {
                search.StudentName = TempName;
            }

            // Display available departments
            Helpers.PrintAllDepartments();

            Console.Write("Enter Student New Department ID: ");
            search.DepartmentID = int.Parse(Console.ReadLine());

            Console.Write("Enter Student New Email (the email must contain @) (Press Enter To Skip): ");
            string email = Console.ReadLine();

            var UniqeEmail = _context.Students.FirstOrDefault(student => student.Email == email);

            // Validate email input
            if (UniqeEmail != null)
            {
                throw new Exception("A student with this email already exists. Please use a different email.");
            }
            else if (!String.IsNullOrEmpty(email))
            {
                if (!email.Contains('@'))
                {
                    throw new Exception("Enter A Vaild Email.");
                }

                search.Email = email;
            }

            // Update student details and save changes
            _context.Update(search);
            _context.SaveChanges();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student Updated Successfully");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Deletes a student from the database.
        /// Prompts the user for confirmation before deleting.
        /// </summary>
        public static void DeleteStudent()
        {
            Console.Write("Enter Student ID: ");
            Student search = SearchForStudent(); // Retrieve student details

            Helpers.PrintStudent(search);
            Console.WriteLine();

            Console.Write("Are You Sure You want To Delete This Student (y/n): ");
            char sure = char.Parse(Console.ReadLine());
            sure = Char.ToLower(sure);

            if (sure == 'y')
            {
                // Find and remove enrollments related to the student
                var StudentEnrollments = _context.Enrollments.Where(e => e.StudentID == search.StudentID).ToList();
                if (StudentEnrollments.Count > 0)
                {
                    _context.RemoveRange(StudentEnrollments);
                }

                // Remove student and save changes
                _context.Remove(search);
                _context.SaveChanges();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Student Deleted Successfully");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Deletion is Cancelled");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
