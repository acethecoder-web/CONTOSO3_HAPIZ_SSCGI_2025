using System.ComponentModel.DataAnnotations;

namespace CONTOSO3_HAPIZ_SSCGI_2025.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}
