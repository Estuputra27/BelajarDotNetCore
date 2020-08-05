using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelajarDotNetCore.Data;
using BelajarDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BelajarDotNetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        public ActionResult Create(Product model)
        {

            
           
            Product product = new Product();
            product.ProductName = model.ProductName;

           

          


            return View(model);
            //return RedirectToAction("Index");
        }
    }
}
