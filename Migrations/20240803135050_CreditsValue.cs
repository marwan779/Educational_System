using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class CreditsValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Credits",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 3,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "Credits",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "Credits",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "Credits",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 4,
                column: "Credits",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 5,
                column: "Credits",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 6,
                column: "Credits",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Credits",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 3);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 1,
                column: "Credits",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 2,
                column: "Credits",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 3,
                column: "Credits",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 4,
                column: "Credits",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 5,
                column: "Credits",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseID",
                keyValue: 6,
                column: "Credits",
                value: 0);
        }
    }
}
