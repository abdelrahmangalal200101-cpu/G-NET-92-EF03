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
            #endregion
        }


    }
}
