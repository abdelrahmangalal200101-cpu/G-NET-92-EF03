using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCore3.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 1, "Software development courses", "Programming", null },
                    { 4, "UI/UX and Graphic Design", "Design", null }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "Id", "Bio", "Email", "FullName", "JoinedDate" },
                values: new object[,]
                {
                    { 1, "Senior .NET & Cloud Architect", "ahmed.tarek@platform.com", "Ahmed Tarek", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Frontend & React Specialist", "sara.mahmoud@platform.com", "Sara Mahmoud", new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "BackEnd Developer .Net", "Mira@gmail.com", "Mira Hashem", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "DateOfBirth", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "omar.khaled@student.com", "Omar Khaled" },
                    { 2, new DateTime(2003, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "nada.hassan@student.com", "Nada Hassan" },
                    { 3, new DateTime(2001, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "youssef.ali@student.com", "Youssef Ali" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[] { 2, "Server-side technologies", "Backend", 1 });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CourseLevel", "Description", "InstructorId", "Price", "PublishedDate", "Title", "isPublished" },
                values: new object[,]
                {
                    { 1, 1, "Beginner", "Learn C# from scratch", 1, 500.00m, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# Fundamentals", true },
                    { 4, 1, "Beginner", "Modern frontend development", 2, 800.00m, null, "React for Beginners", false }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name", "ParentCategoryId" },
                values: new object[] { 3, "Web APIs and MVC", "ASP.NET Core", 2 });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "EnrollmentStatus", "FinalGrade", "ProgressPercentage" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Completed", 94.00m, 100.00m },
                    { 1, 2, new DateTime(2026, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", null, 20.00m }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CourseLevel", "Description", "InstructorId", "Price", "PublishedDate", "Title", "isPublished" },
                values: new object[,]
                {
                    { 2, 3, "intermediate", "Deep dive into Entity Framework Core", 1, 1200.00m, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "EF Core Mastery", true },
                    { 3, 3, "Advanced", "Enterprise application design", 1, 1800.00m, new DateTime(2025, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clean Architecture in .NET", true }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "CourseId", "StudentId", "EnrollmentDate", "EnrollmentStatus", "FinalGrade", "ProgressPercentage" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active", null, 50.00m },
                    { 3, 3, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dropped", null, 10.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
