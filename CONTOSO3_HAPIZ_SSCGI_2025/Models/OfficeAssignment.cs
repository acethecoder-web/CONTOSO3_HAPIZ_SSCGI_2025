using System.ComponentModel.DataAnnotations;

namespace CONTOSO3_HAPIZ_SSCGI_2025.Models
{
    public class OfficeAssignment
    {

        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }

    }
}
