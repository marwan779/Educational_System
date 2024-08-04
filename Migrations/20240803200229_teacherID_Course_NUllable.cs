using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class teacherID_Course_NUllable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Teachers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 3, 19, 16, 18, 335, DateTimeKind.Local).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Teachers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 3, 19, 16, 18, 335, DateTimeKind.Local).AddTicks(7726),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));
        }
    }
}
