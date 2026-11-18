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
        }
    }
}
