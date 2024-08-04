using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class Initiate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Web Development" },
                    { 2, "Mobile Development" },
                    { 3, "Desktop Development" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "DepartmentID", "Email", "TeacherName" },
                values: new object[,]
                {
                    { 1, 1, "john.doe@example.com", "John Doe" },
                    { 2, 1, "Jane.Smith@example.com", "Jane Smith" },
                    { 3, 2, "Alice.Johnson@example.com", "Alice Johnson" },
                    { 4, 2, "Bob.Brown@example.com", "Bob Brown" },
                    { 5, 3, "Charlie.Davis@example.com", "Charlie Davis" },
                    { 6, 3, "Diana.Evans@example.com", "Diana Evans" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseName", "Credits", "DepartmentID", "TeacherID" },
                values: new object[,]
                {
                    { 1, "Introduction to Web Development", 0, 1, 1 },
                    { 2, "Advanced Web Development", 0, 1, 2 },
                    { 3, "Mobile App Development Basics", 0, 2, 3 },
                    { 4, "Advanced Mobile App Development", 0, 2, 4 },
                    { 5, "Introduction to Desktop Development", 0, 3, 5 },
                    { 6, "Advanced Desktop Development", 0, 3, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);
        }
    }
}
