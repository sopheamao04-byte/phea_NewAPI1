using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phea_NewAPI1.Models
{
    [Table("tbl_Students")] // បង្ខំឱ្យបង្កើត Table ឈ្មោះ tbl_Students    
    public class Student
    {
        [Key]
        [Display(Name = "Student ID:")]
        public int StudentId { get; set; } // កំណត់ជា Primary Key

        [Required(ErrorMessage = "ឈ្មោះមិនអាចទទេឡើយ")]
        [MaxLength(100)]
        [Column("FullName")]
        [Display(Name = "Full Name:")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(15)]
        [Display(Name = "Phone Number:")]
        [Column("PhoneNumber")]
        public string? PNumber { get; set; } // អនុញ្ញាតឱ្យ Null បាន (សញ្ញា ?)
    }
}