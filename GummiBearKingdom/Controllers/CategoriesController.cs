using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class CategoriesController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var categoryList = db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Details(int id)
        {
            var thisCategory = db.Categories.Include(categories => categories.Products)
                                 .FirstOrDefault(category => category.CategoryId == id);
            return View(thisCategory);
        }
    }
}
