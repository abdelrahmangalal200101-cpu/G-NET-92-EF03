using EFCore3.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties_Configuration
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.FullName).IsRequired().HasMaxLength(150);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(150);
            builder.Property(i => i.Bio).HasMaxLength(150);
            builder.Property(i => i.JoinedDate).IsRequired().HasDefaultValueSql("GETDATE()");
            builder.HasIndex(i => i.Email).IsUnique();
            builder.HasData
                (
                new Instructor
                {
                    Id = 1,
                    FullName = "Ahmed Tarek",
                    Email = "ahmed.tarek@platform.com",
                    Bio = "Senior .NET & Cloud Architect",
                    JoinedDate = new DateTime(2025, 1, 10)
                },
                new Instructor
                {
                    Id = 2,
                    FullName = "Sara Mahmoud",
                    Email = "sara.mahmoud@platform.com",
                    Bio = "Frontend & React Specialist",
                    JoinedDate = new DateTime(2025, 3, 15)
                },
                new Instructor
                {
                    Id = 3,
                    FullName = "Mira Hashem",
                    Email = "Mira@gmail.com",
                    Bio = "BackEnd Developer .Net",
                    JoinedDate = new DateTime(2025, 1, 3)
                }
                );

        }
    }
}
