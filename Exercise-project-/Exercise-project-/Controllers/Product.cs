using Exercise_project_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_project_.Controllers
{
    public class Product : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Products.Include(x => x.Category).ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> categoryvalue = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.ID.ToString()
                                           }
            ).ToList();
            ViewBag.categoryvalues = categoryvalue;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Models.Product p)
        {
            if (Request.Files.c)

            {

                var extention = Path.GetExtension(Request.Files[0].FileName);

                var randomName = string.Format($"{DateTime.Now.Ticks}{extention}");

                //var randomName = string.Format($"{Guid.NewGuid().ToString().Replace("-", "")}{extention}");

                p.Image = "/Images/" + randomName;

                var path = "~/Images/" + randomName;

                Request.Files[0].SaveAs(Server.MapPath(path));

            }
            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var deger = context.Products.Find(id);
            if (deger.ProductStatus == true)
            {
                deger.ProductStatus = false;
            }
            else
            {
                deger.ProductStatus = true;
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunGetir(int id)
        {
            List<SelectListItem> deger1 = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.ID.ToString()
                                           }
           ).ToList();
            ViewBag.deger1 = deger1;
            var urundeger = context.Products.Find(id);
            return View("UrunGetir", urundeger);
        }
        [HttpGet]
        public ActionResult UpdateProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateProduct(Models.Product p)
        {
            var deger = context.Products.Find(p.ID);

            deger.ProductName = p.ProductName;
            deger.Image = p.Image;
            deger.unitprice = p.unitprice ;
            deger.CategoryID = p.CategoryID;
            deger.ProductStatus = p.ProductStatus;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
