using EFCore3.Enteties;
using Microsoft.EntityFrameworkCore;
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

        public static void EnrollStudent(OnlineLearningDbContext context, Enrollment enrollment)
        {
            if (!context.Student.Any(i => i.Id == enrollment.StudentId))
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
            };

            context.Add(enrollment);
            context.SaveChanges();
            Console.WriteLine($"Enrollment Was Added Successfully With StudentId {enrollment.StudentId}, And Course {enrollment.CourseId}");
        }

        public static void FindCourseById(OnlineLearningDbContext context, int id)
        {
            var FoundedCourse = context.Course.Find(id);

            if (FoundedCourse == null)
            {
                Console.WriteLine($"There Is Bo Course With Id {id}");
            }
            else
            {
                Console.WriteLine($"Course Found: {FoundedCourse.Title} - Price: {FoundedCourse.Price}");
            }

        }

        public static void FindByTitle(OnlineLearningDbContext context, string title)
        {
            var FoundedCourse = context.Course.FirstOrDefault(c => c.Title == title);

            if (FoundedCourse == null)
            {
                Console.WriteLine("not Found");
            }
            else
            {
                Console.WriteLine($"Course Found: {FoundedCourse.Title} - Price: {FoundedCourse.Price}");
            }
        }

        public static void FilterByPrice(OnlineLearningDbContext context, decimal minPrice, decimal maxPrice)
        {
            var courses = context.Course.AsNoTracking().Where(c => c.Price >= minPrice && c.Price <= maxPrice)
                .OrderByDescending(c => c.Price).Select(c => new
                {
                    c.Title,
                    c.CourseLevel,
                    c.Price
                }).ToList();

            foreach (var c in courses)
            {
                Console.WriteLine($"Title: {c.Title} | Level: {c.CourseLevel} | Price: {c.Price}");
            }
        }

        public static void FindSubCategory(OnlineLearningDbContext context, int categoryId)
        {
            var subCategories = context.Category.AsNoTracking().Where(c => c.ParentCategoryId == categoryId);

            foreach (var c in subCategories)
            {
                Console.WriteLine($"SubName : {c.Name} , Id : {c.Id}");
            }
        }

        public static void FindTopCategories(OnlineLearningDbContext context)
        {
            var TopCategoreis = context.Category.AsNoTracking().Where(c => c.ParentCategoryId == null);

            foreach (var c in TopCategoreis)
            {
                Console.WriteLine($"Top Category Name {c.Name} , Its Id {c.Id}");
            }
        }

        public static void FindStudentsByCourseId(OnlineLearningDbContext context, int CourseId)
        {
            var StudentIds = context.Enrollment.Where(e => e.CourseId == CourseId).Select(e => e.StudentId).ToList();
            var Students = context.Student.Where(s => StudentIds.Contains(s.Id));

            Console.WriteLine($"Number Of Students For This Course {Students.Count()}");
            foreach (var student in Students)
            {
                Console.WriteLine($"Student Name :- {student.FullName} , Student Id :- {student.Id}");
            }
        }

        public static void ChangeCoursePrice(OnlineLearningDbContext context , int CourseId , decimal newPrice)
        {
            var course = context.Course.Find(CourseId);

            if (course == null)
            {
                Console.WriteLine("Didnt Find This Course");
            }

            course.Price = newPrice;
            context.SaveChanges();
            Console.WriteLine($"Course Name :- {course.Title} , New Price = {course.Price}");

        }
    }
}
