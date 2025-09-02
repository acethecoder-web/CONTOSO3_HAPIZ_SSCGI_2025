using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CONTOSO3_HAPIZ_SSCGI_2025.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        
        [ValidateNever]
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
