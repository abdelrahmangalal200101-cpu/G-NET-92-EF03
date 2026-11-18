using EFCore3.Enteties;
using EFCore3.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties_Configuration
{
    internal class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> builder)
        {
            builder.Property(e => e.EnrollmentDate).IsRequired();
            builder.Property(e => e.ProgressPercentage).IsRequired().HasPrecision(5, 2);
            builder.Property(e => e.EnrollmentStatus).IsRequired().HasConversion<string>();
            builder.Property(e => e.FinalGrade).HasPrecision(5, 2);
            builder.HasKey(e => new { e.CourseId, e.StudentId });
            builder.HasOne(e => e.Student).WithMany(s => s.Enrollments).HasForeignKey(e => e.StudentId);
            builder.HasOne(e => e.Course).WithMany(c => c.Enrollments).HasForeignKey(e => e.CourseId);
            builder.HasData(
                new Enrollment
                {
                    StudentId = 1,
                    CourseId = 1,
                    EnrollmentDate = new DateTime(2026, 1, 10),
                    ProgressPercentage = 100.00m,
                    EnrollmentStatus = Status.Completed,
                    FinalGrade = 94.00m
                },
                new Enrollment
                {
                    StudentId = 1,
                    CourseId = 2,
                    EnrollmentDate = new DateTime(2026, 2, 5),
                    ProgressPercentage = 50.00m,
                    EnrollmentStatus = Status.Active,
                    FinalGrade = null
                },
                new Enrollment
                {
                    StudentId = 2,
                    CourseId = 1,
                    EnrollmentDate = new DateTime(2026, 2, 12),
                    ProgressPercentage = 20.00m,
                    EnrollmentStatus = Status.Active,
                    FinalGrade = null
                },
                new Enrollment
                {
                    StudentId = 3,
                    CourseId = 3,
                    EnrollmentDate = new DateTime(2026, 3, 1),
                    ProgressPercentage = 10.00m,
                    EnrollmentStatus = Status.Dropped,
                    FinalGrade = null
                }
                );
        }
    }
}
