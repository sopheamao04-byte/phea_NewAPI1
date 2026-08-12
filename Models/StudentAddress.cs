using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phea_NewAPI1.Models
{
    public class StudentAddress
    {
        public int Id { get; set; }
        public string City { get; set; } = string.Empty;

        // Foreign Key ភ្ជាប់ទៅ Student
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}