using EFCore3.Enteties;
using EFCore3.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties_Configuration
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(1000);
            builder.Property(c => c.Price).IsRequired().HasPrecision(18, 2);
            builder.Property(c => c.CourseLevel).IsRequired().HasConversion<string>();
            builder.Property(c => c.isPublished).IsRequired();
            builder.HasOne(c => c.Instructor).WithMany(i => i.Courses).HasForeignKey(c => c.InstructorId);
            builder.HasOne(c => c.Category).WithMany(c => c.Courses).HasForeignKey(c => c.CategoryId);
            builder.HasData(
                new Course
                {
                    Id = 1,
                    Title = "C# Fundamentals",
                    Description = "Learn C# from scratch",
                    Price = 500.00m,
                    CourseLevel = Level.Beginner,
                    isPublished = true,
                    PublishedDate = new DateTime(2025, 5, 1),
                    InstructorId = 1,
                    CategoryId = 1
                },
                new Course
                {
                    Id = 2,
                    Title = "EF Core Mastery",
                    Description = "Deep dive into Entity Framework Core",
                    Price = 1200.00m,
                    CourseLevel = Level.intermediate,
                    isPublished = true,
                    PublishedDate = new DateTime(2025, 6, 15),
                    InstructorId = 1,
                    CategoryId = 3
                },
                new Course
                {
                    Id = 3,
                    Title = "Clean Architecture in .NET",
                    Description = "Enterprise application design",
                    Price = 1800.00m,
                    CourseLevel = Level.Advanced,
                    isPublished = true,
                    PublishedDate = new DateTime(2025, 8, 20),
                    InstructorId = 1,
                    CategoryId = 3
                },
                new Course
                {
                    Id = 4,
                    Title = "React for Beginners",
                    Description = "Modern frontend development",
                    Price = 800.00m,
                    CourseLevel = Level.Beginner,
                    isPublished = false,
                    PublishedDate = null,
                    InstructorId = 2,
                    CategoryId = 1
                }
                );

        }
    }
}
