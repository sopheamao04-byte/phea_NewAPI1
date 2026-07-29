using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace NewAPI1.Models
{
    public class Category
    {
        [Key]
        public int CatId { get; set;}
        public string CatName { get; set;} = "";   
        // Navigation Property: Category មួយមាន Products ច្រើន
        public ICollection<Product> Products { get; set; } = new List<Product>();     
    }
}