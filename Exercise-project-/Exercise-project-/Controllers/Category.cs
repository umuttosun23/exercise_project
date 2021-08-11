using Exercise_project_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_project_.Controllers
{
    public class Category : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.Categories.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Models.Category p)
        {        
            c.Categories.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var deger = c.Categories.Find(id);
            if (deger.CategoryStatus == true)
            {
                deger.CategoryStatus = false;
            }
            else
            {
                deger.CategoryStatus = true;
            }
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var aranan = c.Categories.Find(id);
            return View("UpdateCategory",aranan);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Models.Category p)
        {
            var ktgr = c.Categories.Find(p.ID);
            ktgr.Name = p.Name;
            ktgr.CategoryStatus = p.CategoryStatus;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
