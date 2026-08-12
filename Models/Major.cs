using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phea_NewAPI1.Models
{
    [Table("tbl_Majors")]
    public class Major
    {
      [Key]
        
        [Display(Name = "Major ID:")]
        public int MajorId { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("MajorName")]
        [Display(Name = "Major Name:")]
        public string Name { get; set; } = string.Empty;

    // Navigation Property: ជំនាញមួយ មាននិស្សិតច្រើននាក់
    public List<Student> Students { get; set; } = new List<Student>();  
    }
}