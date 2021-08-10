﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace exercise_project.Models
{
    public class Kategories
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Products> products { get; set; }
    }
}
