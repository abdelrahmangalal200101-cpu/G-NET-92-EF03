using EFCore3.Enteties;
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
            builder.Property(c =>  c.Description).HasMaxLength(1000);
            builder.Property(c => c.Price).IsRequired().HasPrecision(18, 2);
            builder.Property(c => c.CourseLevel).IsRequired().HasConversion<string>();
            builder.Property(c => c.isPublished).IsRequired();
            builder.HasOne(c => c.Instructor).WithMany(i => i.Courses).HasForeignKey(c => c.InstructorId);
            builder.HasOne(c => c.Category).WithMany(c => c.Courses).HasForeignKey(c => c.CategoryId);

        }
    }
}
