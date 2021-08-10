using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_project.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal unitprice { get; set; }
        public string Image { get; set; }


        public int Categoryid { get; set; }
        public Kategories Kategories { get; set; }
    }
}
