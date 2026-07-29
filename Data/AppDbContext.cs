using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewAPI1.Models;
using Microsoft.EntityFrameworkCore;
using NewAPI1.Data;

namespace NewAPI1.Data
{
    // ត្រូវតែស្នងត្រកូលពី class DbContext របស់ EF Core
    public class AppDbContext : DbContext
    {
        // Constructor សម្រាប់ទទួលយកការកំណត់ (Connection String) ពី Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}