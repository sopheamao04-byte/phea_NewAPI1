using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewAPI1.Models
{
    public class Product
    {
        [Key]
        public int ProID{set;get;}
        // Foreign Key
        public int CatId { get; set; } = 0;
        public string ProName{set;get;} = "";
        public decimal Price{set;get;} = 0;
        public int Quantity{set;get;} = 0;

        // Navigation Property: Product នេះជារបស់ Category មួយ
        [ForeignKey("CatId")]
        public Category Category { get; set; }
    }
}