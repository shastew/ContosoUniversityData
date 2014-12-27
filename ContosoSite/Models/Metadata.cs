using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoSite.Models
{
    public class StudentMetadata
    {
        [StringLength(50)]
        [Required]
        public string LastName;

        [StringLength(50)]
        [Required]
        public string FirstName;

        [StringLength(50)]
        public string MiddleName;

        [Phone]
        [Required(ErrorMessage="Telephone Number is Required")]
        public string PhoneNumber;

        [Required(ErrorMessage = "Gender is Required")]
        [RegularExpression(@"(Male)|(Female)", ErrorMessage = "Invalid Gender (must be Male or Female)")]
        public string Gender; 
    }

    public class EnrollmentMetadata
    {
        [Range(0, 4)]
        public Nullable<decimal> Grade;
    }
}