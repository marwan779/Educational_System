using Educational_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Educational_System
{
    public class EducationalSystemDbContext : DbContext
    {
        // Configures the database provider and connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQL Server with the provided connection string
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-VMDABBJ\SQLEXPRESS;Database=EducationalSystem;Integrated Security=True;TrustServerCertificate=True;");
        }

        // DbSets for each entity type
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        // Configures the entity relationships and data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* Seed initial data for the application */

            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentID = 1, DepartmentName = "Web Development" },
                new Department { DepartmentID = 2, DepartmentName = "Mobile Development" },
                new Department { DepartmentID = 3, DepartmentName = "Desktop Development" }
            );

            // Seed Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherID = 1, TeacherName = "John Doe", DepartmentID = 1, Email = "john.doe@example.com" },
                new Teacher { TeacherID = 2, TeacherName = "Jane Smith", DepartmentID = 1, Email = "Jane.Smith@example.com" },
                new Teacher { TeacherID = 3, TeacherName = "Alice Johnson", DepartmentID = 2, Email = "Alice.Johnson@example.com" },
                new Teacher { TeacherID = 4, TeacherName = "Bob Brown", DepartmentID = 2, Email = "Bob.Brown@example.com" },
                new Teacher { TeacherID = 5, TeacherName = "Charlie Davis", DepartmentID = 3, Email = "Charlie.Davis@example.com" },
                new Teacher { TeacherID = 6, TeacherName = "Diana Evans", DepartmentID = 3, Email = "Diana.Evans@example.com" },
                new Teacher { TeacherID = 7, TeacherName = "test", DepartmentID = 3, Email = "test@example.com" }
            );

            // Seed Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseID = 1, CourseName = "Introduction to Web Development", DepartmentID = 1, TeacherID = 1 },
                new Course { CourseID = 2, CourseName = "Advanced Web Development", DepartmentID = 1, TeacherID = 2 },
                new Course { CourseID = 3, CourseName = "Mobile App Development Basics", DepartmentID = 2, TeacherID = 3 },
                new Course { CourseID = 4, CourseName = "Advanced Mobile App Development", DepartmentID = 2, TeacherID = 4 },
                new Course { CourseID = 5, CourseName = "Introduction to Desktop Development", DepartmentID = 3, TeacherID = 5 },
                new Course { CourseID = 6, CourseName = "Advanced Desktop Development", DepartmentID = 3, TeacherID = 6 },
                new Course { CourseID = 7, CourseName = "C++", DepartmentID = 3, TeacherID = 7 },
                new Course { CourseID = 8, CourseName = "C#", DepartmentID = 2, TeacherID = 3 }
            );

            // Configure Student entity
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department) // A student belongs to one department
                .WithMany(d => d.Students) // A department has many students
                .HasForeignKey(s => s.DepartmentID);

            modelBuilder.Entity<Student>()
                .Property(d => d.DateOfBirth) // Configure column type for DateOfBirth
                .HasColumnType("date");

            modelBuilder.Entity<Student>()
                .Property(d => d.EnrollmentDate) // Configure column type for EnrollmentDate
                .HasColumnType("date")
                .HasDefaultValue(DateTime.Now); // Default value for EnrollmentDate

            // Configure Enrollment entity
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentID, e.CourseID }); // Composite primary key

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student) // An enrollment is for one student
                .WithMany(s => s.Enrollments) // A student has many enrollments
                .HasForeignKey(e => e.StudentID)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of student if there are enrollments

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course) // An enrollment is for one course
                .WithMany(c => c.Enrollments) // A course has many enrollments
                .HasForeignKey(e => e.CourseID)
                .OnDelete(DeleteBehavior.Restrict); // Restrict deletion of course if there are enrollments

            modelBuilder.Entity<Enrollment>()
                .Property(d => d.EnrollmentDate) // Configure column type for EnrollmentDate
                .HasColumnType("date")
                .HasDefaultValue(DateTime.Now); // Default value for EnrollmentDate

            // Configure Teacher entity
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Department) // A teacher belongs to one department
                .WithMany(d => d.Teachers) // A department has many teachers
                .HasForeignKey(t => t.DepartmentID);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Email) // Configure email as required with max length
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Teacher>()
                .Property(h => h.HireDate) // Configure column type for HireDate
                .HasColumnType("date")
                .HasDefaultValue(DateTime.Now); // Default value for HireDate

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Salary)
                .HasDefaultValue(6000.0);

            // Configure Course entity
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Department) // A course belongs to one department
                .WithMany(d => d.Courses) // A department has many courses
                .HasForeignKey(c => c.DepartmentID);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher) // A course is taught by one teacher
                .WithMany(t => t.Courses) // A teacher teaches many courses
                .HasForeignKey(c => c.TeacherID)
                .OnDelete(DeleteBehavior.NoAction); // No action on delete of teacher

            modelBuilder.Entity<Course>()
                .Property(e => e.Credits) // Configure default value for Credits
                .HasDefaultValue(3);
        }
    }
}
