using EFCore3.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties_Configuration
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.FullName).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Email).IsRequired().HasMaxLength(100);
            builder.HasIndex(s => s.Email).IsUnique();
            builder.Property(s => s.DateOfBirth).IsRequired();
            builder.HasData(
                new Student
                {
                    Id = 1,
                    FullName = "Omar Khaled",
                    Email = "omar.khaled@student.com",
                    DateOfBirth = new DateTime(2002, 4, 12)
                },
                new Student
                {
                    Id = 2,
                    FullName = "Nada Hassan",
                    Email = "nada.hassan@student.com",
                    DateOfBirth = new DateTime(2003, 9, 25)
                },
                new Student
                {
                    Id = 3,
                    FullName = "Youssef Ali",
                    Email = "youssef.ali@student.com",
                    DateOfBirth = new DateTime(2001, 11, 3)
                }
                );
        }
    }
}
