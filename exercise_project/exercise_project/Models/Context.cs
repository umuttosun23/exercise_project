using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_project.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GBPinG\\SQLEXPRESS;database=e-commerce;integrated security=true;");
        }
        public DbSet<Kategories> Kategories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
