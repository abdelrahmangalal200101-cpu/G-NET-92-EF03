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

        public static void AddCourse(OnlineLearningDbContext context, Course course)
        {
            if (!context.Instructor.Any(i => i.Id == course.InstructorId))
            {
                Console.WriteLine("Couldnt Found This Instructor");
                return;
            }
            if (!context.Category.Any(c => c.Id == course.CategoryId))
            {
                Console.WriteLine("Couldnt Found This Category");
                return;
            }

            context.Add(course);
            context.SaveChanges();
            Console.WriteLine($"Course is Added Succesfully With Name {course.Title} , With Id {course.Id}");


        }

        public static void AddStudents(OnlineLearningDbContext context, List<Student> students)
        {
            context.AddRange(students);
            context.SaveChanges();
            foreach (Student s in students)
            {
                Console.WriteLine($"Student Added Successfully With Id {s.Id}");
            }
        }

        public static void EnrollStudent(OnlineLearningDbContext context,  Enrollment enrollment) 
        {
            if(!context.Student.Any(i => i.Id == enrollment.StudentId))
            {
                Console.WriteLine("There Is No Student Have Id Like That");
                return;
            }
            if (!context.Course.Any(c => c.Id == enrollment.CourseId))
            {
                Console.WriteLine("There Is No Course Have Id Like That");
                return;
            }

            if (context.Enrollment.Any(e => e.StudentId == enrollment.StudentId && e.CourseId == enrollment.CourseId)) 
            {
                Console.WriteLine("The Student Musnt Access This Course Twice");
                return;
            } ;

            context.Add(enrollment);
            context.SaveChanges();
            Console.WriteLine($"Enrollment Was Added Successfully With StudentId {enrollment.StudentId}, And Course {enrollment.CourseId}");
        }
    }
}
