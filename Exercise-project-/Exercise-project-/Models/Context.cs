using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_project_.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=GBPinG\\SQLEXPRESS;database=Dbexercise;integrated security=true;");
        }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Product>Products { get; set; }
    }
}
