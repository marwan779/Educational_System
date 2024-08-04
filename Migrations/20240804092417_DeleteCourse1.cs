using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCourse1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Teachers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 12, 24, 15, 912, DateTimeKind.Local).AddTicks(7379),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 179, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Teachers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 4, 12, 24, 15, 913, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 179, DateTimeKind.Local).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 4, 12, 24, 15, 912, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 6,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 7,
                column: "HireDate",
                value: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Courses_CourseID",
                table: "Enrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
