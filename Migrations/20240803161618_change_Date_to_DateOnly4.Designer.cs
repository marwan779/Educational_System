﻿// <auto-generated />
using System;
using Educational_System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Educational_System.Migrations
{
    [DbContext(typeof(EducationalSystemDbContext))]
    [Migration("20240803161618_change_Date_to_DateOnly4")]
    partial class change_Date_to_DateOnly4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Educational_System.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credits")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(3);

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1,
                            CourseName = "Introduction to Web Development",
                            Credits = 0,
                            DepartmentID = 1,
                            TeacherID = 1
                        },
                        new
                        {
                            CourseID = 2,
                            CourseName = "Advanced Web Development",
                            Credits = 0,
                            DepartmentID = 1,
                            TeacherID = 2
                        },
                        new
                        {
                            CourseID = 3,
                            CourseName = "Mobile App Development Basics",
                            Credits = 0,
                            DepartmentID = 2,
                            TeacherID = 3
                        },
                        new
                        {
                            CourseID = 4,
                            CourseName = "Advanced Mobile App Development",
                            Credits = 0,
                            DepartmentID = 2,
                            TeacherID = 4
                        },
                        new
                        {
                            CourseID = 5,
                            CourseName = "Introduction to Desktop Development",
                            Credits = 0,
                            DepartmentID = 3,
                            TeacherID = 5
                        },
                        new
                        {
                            CourseID = 6,
                            CourseName = "Advanced Desktop Development",
                            Credits = 0,
                            DepartmentID = 3,
                            TeacherID = 6
                        },
                        new
                        {
                            CourseID = 7,
                            CourseName = "C++",
                            Credits = 0,
                            DepartmentID = 3,
                            TeacherID = 7
                        },
                        new
                        {
                            CourseID = 8,
                            CourseName = "C#",
                            Credits = 0,
                            DepartmentID = 2,
                            TeacherID = 3
                        });
                });

            modelBuilder.Entity("Educational_System.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            DepartmentName = "Web Development"
                        },
                        new
                        {
                            DepartmentID = 2,
                            DepartmentName = "Mobile Development"
                        },
                        new
                        {
                            DepartmentID = 3,
                            DepartmentName = "Desktop Development"
                        });
                });

            modelBuilder.Entity("Educational_System.Models.Enrollment", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("date");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Educational_System.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EnrollmentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValue(new DateTime(2024, 8, 3, 19, 16, 18, 335, DateTimeKind.Local).AddTicks(7726));

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Educational_System.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("HireDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValue(new DateTime(2024, 8, 3, 19, 16, 18, 336, DateTimeKind.Local).AddTicks(3489));

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            DepartmentID = 1,
                            Email = "john.doe@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "John Doe"
                        },
                        new
                        {
                            TeacherID = 2,
                            DepartmentID = 1,
                            Email = "Jane.Smith@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "Jane Smith"
                        },
                        new
                        {
                            TeacherID = 3,
                            DepartmentID = 2,
                            Email = "Alice.Johnson@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "Alice Johnson"
                        },
                        new
                        {
                            TeacherID = 4,
                            DepartmentID = 2,
                            Email = "Bob.Brown@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "Bob Brown"
                        },
                        new
                        {
                            TeacherID = 5,
                            DepartmentID = 3,
                            Email = "Charlie.Davis@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "Charlie Davis"
                        },
                        new
                        {
                            TeacherID = 6,
                            DepartmentID = 3,
                            Email = "Diana.Evans@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "Diana Evans"
                        },
                        new
                        {
                            TeacherID = 7,
                            DepartmentID = 3,
                            Email = "test@example.com",
                            HireDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeacherName = "test"
                        });
                });

            modelBuilder.Entity("Educational_System.Models.Course", b =>
                {
                    b.HasOne("Educational_System.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Educational_System.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Department");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Educational_System.Models.Enrollment", b =>
                {
                    b.HasOne("Educational_System.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Educational_System.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Educational_System.Models.Student", b =>
                {
                    b.HasOne("Educational_System.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Educational_System.Models.Teacher", b =>
                {
                    b.HasOne("Educational_System.Models.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Educational_System.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Educational_System.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Educational_System.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Educational_System.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
