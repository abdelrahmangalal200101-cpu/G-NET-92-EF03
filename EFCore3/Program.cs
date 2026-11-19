using EFCore3.Enteties;
using EFCore3.Enums;

namespace EFCore3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new OnlineLearningDbContext();

            #region Create Question
            #region Question 01 

            // Add an instructor: Insert a new instructor and print the generated Id.

            //Instructor instructor = new Instructor
            //{
            //    FullName = "Karim Adel",
            //    Email = "karim.adel@platform.com",
            //    Bio = "Full-Stack .NET & Angular Developer",
            //    JoinedDate = DateTime.Now
            //};

            //Methods.AddInstructor(context, instructor);

            #endregion
            #region Question 02
            // Add a course: Insert a course for an existing instructor and an existing category.
            // Check that both exist first, otherwise print a message.

            //Course course = new Course
            //{
            //    Title = "ASP.NET Core Web API",
            //    Description = "Build RESTful APIs with .NET",
            //    Price = 1500.00m,
            //    CourseLevel = Level.intermediate,
            //    isPublished = true,
            //    PublishedDate = DateTime.Now,
            //    InstructorId = 1,
            //    CategoryId = 3
            //};

            //Methods.AddCourse(context, course);
            #endregion
            #region Question 03

            // Add several students: Insert three students using one AddRange and one SaveChanges. Print their generated Ids.

            //        List<Student> students = new List<Student>
            //        {
            //            new Student
            //            {
            //    FullName = "Omar Tarek",
            //    Email = "omar.tarek@student.com",
            //    DateOfBirth = new DateTime(2002, 5, 14)
            //},
            //            new Student
            //            {
            //    FullName = "Nourhan Essam",
            //    Email = "nourhan.essam@student.com",
            //    DateOfBirth = new DateTime(2003, 9, 22)
            //},
            //            new Student
            //            {
            //    FullName = "Youssef Mahmoud",
            //    Email = "youssef.mahmoud@student.com",
            //    DateOfBirth = new DateTime(2001, 11, 3)
            //}
            //        };

            //        Methods.AddStudents(context, students);
            #endregion
            #region Question 04
            // Enroll a student in a course: Insert an enrollment linking a student and a course.
            // Check that both exist and that the student is not already enrolled in that course before inserting.

            //Enrollment enrollment = new Enrollment
            //{
            //    StudentId = 1,
            //    CourseId = 4,
            //    EnrollmentDate = DateTime.Now,
            //    ProgressPercentage = 0.00m,
            //    EnrollmentStatus = Status.Active,
            //    FinalGrade = null
            //};

            //Methods.EnrollStudent(context, enrollment);


            #endregion


            #endregion
            #region Read Questions 
            #region Question 01
            // Find a course: Get a course by Id using Find, then by title using FirstOrDefault.
            // Print "not found" when the result is null.

            //Methods.FindCourseById(context, 1);
            //Methods.FindByTitle(context, "C# Fundamentals");
            #endregion
            #region Question 02
            // Filter courses: Courses priced between two values, ordered by price descending.
            // Print only the title, level and price.

            //Methods.FilterByPrice(context, 600, 1000);
            #endregion
            #region Question 03

            //Methods.FindSubCategory(context, 1);
            //Methods.FindTopCategories(context);
            #endregion
            #region Question 04

            //Methods.FindStudentsByCourseId(context, 1);
            #endregion
            #endregion
            #region Update Questions 
            #region Question 01
            // Change a price: Load a course, change its price, and save.

            //Methods.ChangeCoursePrice(context, 1, 800);

            #endregion
            #endregion
        }


    }
}
