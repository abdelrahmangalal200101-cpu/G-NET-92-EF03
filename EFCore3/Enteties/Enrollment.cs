using EFCore3.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore3.Enteties
{
    public class Enrollment
    {
        public DateTime EnrollmentDate { get; set; }
        public decimal ProgressPercentage { get; set; }
        public Status EnrollmentStatus { get; set; }
        public decimal? FinalGrade { get; set; }


    }
}
