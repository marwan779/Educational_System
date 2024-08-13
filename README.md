"# Educational System Management"
---------------------------------
Project Overview
----------------
This project is a comprehensive educational system management application built using C# and Entity Framework Core. It is designed to manage students, teachers, courses, and enrollments within an educational institution. The system allows users to perform CRUD operations on students, teachers, and courses, as well as manage course enrollments for students and assign courses to teachers.

Features
--------
Student Management: Add, search, update, and delete student records. View details of all students.
Teacher Management: Add, search, update, and delete teacher records. Assign and deassign courses to teachers.
Course Management: Add, search, update, and delete courses. Assign courses to students and teachers.
Enrollment Management: Add and remove course enrollments for students. View all courses a student is enrolled in.
Technologies Used
C#: The primary programming language used for the application.
Entity Framework Core: ORM for database management.
Microsoft SQL Server: Database used to store the application data.

Getting Started
---------------

Prerequisites
.NET Core SDK (version X.X or later)
Microsoft SQL Server or another compatible database server

1- Clone the Repository:

2- Install Dependencies:
Make sure you have the necessary NuGet packages installed. You can do this by running:
dotnet restore

3- Configure the Database:
Update the connection string in the appsettings.json file to match your database server settings.
Run Migrations:

4- Apply any pending migrations to your database by running:
dotnet ef database update

5- Build and Run the Application:
dotnet build
dotnet run

Usage
-----

Launch the application.
Follow the on-screen prompts to manage students, teachers, courses, and enrollments.
Project Structure
Educational_System/Models: Contains the data models for students, teachers, courses, and enrollments.
Educational_System/CRUD: Contains the classes responsible for performing CRUD operations on the database.
Educational_System/Program.cs: Entry point of the application.
Contributing
Feel free to contribute to this project by submitting issues, feature requests, or pull requests. Please follow the standard GitHub flow for contributing:

Fork the repository.
Create a new branch for your feature or fix.
Make your changes and commit them.
Push to your fork and create a pull request.

Contact
-------
For any questions or inquiries, please contact [https://www.linkedin.com/in/marwan-mohamed-125a4b252/].
