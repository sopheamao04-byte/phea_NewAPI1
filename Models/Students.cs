using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phea_NewAPI1.Models
{
   public class Students
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // One-to-Many (ជាមួយ Department)
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

    // One-to-One (ជាមួយ StudentAddress)
    public StudentAddress Address { get; set; }

    // Many-to-Many (ជាមួយ Course)
    public ICollection<Course> Courses { get; set; }
}

}