using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CONTOSO3_HAPIZ_SSCGI_2025.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [ValidateNever]
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
