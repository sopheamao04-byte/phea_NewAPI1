using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phea_NewAPI1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // One-To-Many
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}