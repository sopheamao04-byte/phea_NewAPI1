using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Phea_NewAPI1.Models;
using Microsoft.EntityFrameworkCore;
using Phea_NewAPI1.Data;


namespace Phea_NewAPI1.Data
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
        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; } 
        public DbSet<Department> Departments { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Studentss { get; set; }
    }
}