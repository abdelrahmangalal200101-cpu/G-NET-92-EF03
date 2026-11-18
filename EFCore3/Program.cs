using EFCore3.Enteties;

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

            Instructor instructor = new Instructor
            {
                FullName = "Karim Adel",
                Email = "karim.adel@platform.com",
                Bio = "Full-Stack .NET & Angular Developer",
                JoinedDate = DateTime.Now
            };

            Methods.AddInstructor(context, instructor);

            #endregion



            #endregion
        }


    }
}
