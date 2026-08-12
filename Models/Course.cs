using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phea_NewAPI1.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        // Many-To-Many: Course មួយ អាចមាន Student រៀនច្រើននាក់
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}