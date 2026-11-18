using EFCore3.Enteties;
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
        }
    }
}
