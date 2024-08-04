using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "DepartmentID", "Email", "TeacherName" },
                values: new object[] { 7, 3, "test@example.com", "test" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseName", "DepartmentID", "TeacherID" },
                values: new object[] { 7, "C++", 3, 7 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 7);
        }
    }
}
