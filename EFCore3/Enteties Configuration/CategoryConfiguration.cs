using EFCore3.Enteties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties_Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Description).HasMaxLength(200);
            builder.HasOne(c => c.ParentCategory).WithMany(s => s.SubCategories).HasForeignKey(c => c.ParentCategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                new Category { Id = 1, Name = "Programming", Description = "Software development courses", ParentCategoryId = null },
                new Category { Id = 2, Name = "Backend", Description = "Server-side technologies", ParentCategoryId = 1 },
                new Category { Id = 3, Name = "ASP.NET Core", Description = "Web APIs and MVC", ParentCategoryId = 2 },
                new Category { Id = 4, Name = "Design", Description = "UI/UX and Graphic Design", ParentCategoryId = null }
                );
        }
    }
}
