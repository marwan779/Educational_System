using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Educational_System.Migrations
{
    /// <inheritdoc />
    public partial class delete_teacher2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Teachers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 179, DateTimeKind.Local).AddTicks(7199),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(1058));

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
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HireDate",
                table: "Teachers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(6736),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 180, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Students",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 3, 23, 2, 29, 531, DateTimeKind.Local).AddTicks(1058),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValue: new DateTime(2024, 8, 4, 10, 50, 38, 179, DateTimeKind.Local).AddTicks(7199));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "TeacherID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
