using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_project_.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal unitprice { get; set; }
        public string Image { get; set; }
        public bool ProductStatus { get; set; }
        public int CategoryID { get; set; }
        public Category  Category { get; set; }
    }
}
