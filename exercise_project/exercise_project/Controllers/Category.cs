using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercise_project.Models;
namespace exercise_project.Controllers
{
    public class Category : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Kategories.ToList();
            return View(degerler);
        }
    }
}
