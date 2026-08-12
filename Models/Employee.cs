using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phea_NewAPI1.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public string EmpEmail { get; set; } = string.Empty;
        public string EmpPhone { get; set; } = string.Empty;
        public DateTime EmpDOB { get; set; } = DateTime.Now;        
    }
}