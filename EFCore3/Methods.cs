using EFCore3.Enteties;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3
{
    public static class Methods
    {
        public static void AddInstructor(OnlineLearningDbContext context, Instructor instructor)
        {
            context.Add(instructor);
            context.SaveChanges();
            Console.WriteLine($"Instructor added successfully with Id: {instructor.Id}");
        }

        public static void AddCourse(OnlineLearningDbContext context , Course course) 
        {
            if (!context.Instructor.Any(i => i.Id == course.InstructorId))
            {
                Console.WriteLine("Couldnt Found This Instructor");
            }
            if (!context.Category.Any(c => c.Id == course.CategoryId))
            {
                Console.WriteLine("Couldnt Found This Category");
            }

            context.Add(course);
            context.SaveChanges();
            Console.WriteLine($"Course is Added Succesfully With Name {course.Title} , With Id {course.Id}");


        }
    }
}
