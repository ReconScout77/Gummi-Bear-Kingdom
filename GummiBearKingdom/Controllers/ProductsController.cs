using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Contracts;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var productList = db.Products.ToList();
            return View(productList);
        }

        public IActionResult Details(int id)
        {
            var thisProduct = db.Products.Include(product => product.Category)
                               .FirstOrDefault(product => product.ProductId == id);
            return View(thisProduct);
        }

        public IActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
