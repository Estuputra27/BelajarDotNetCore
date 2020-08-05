using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelajarDotNetCore.Data;
using BelajarDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BelajarDotNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly BelajarDotNetCoreContext _context;

        public ProductController(BelajarDotNetCoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product model)
        {

            try {
                model.ProductName = model.ProductName;
                _context.Add(model);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }catch(DbUpdateException)
            {
                ModelState.AddModelError("", "Failed to create products");
                return RedirectToAction("Create");
            }
          
            //return RedirectToAction("Index");
        }
    }
}
