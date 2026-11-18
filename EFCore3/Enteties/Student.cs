using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
