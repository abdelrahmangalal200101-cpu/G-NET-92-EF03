using EFCore3.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public Level CourseLevel { get; set; }
        public bool isPublished { get; set; }
        public DateTime? PublishedDate { get; set; } 


    }
}
