using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercise_project.Models;
namespace exercise_project.Controllers
{
    public class Product : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Products.ToList();
            return View(degerler);
        }
    }
}
