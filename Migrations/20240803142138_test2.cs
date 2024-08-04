using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "CourseName", "DepartmentID", "TeacherID" },
                values: new object[] { 8, "C#", 2, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 8);
        }
    }
}
