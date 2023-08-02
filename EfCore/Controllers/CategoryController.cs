using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EfCore.Models.Context;
using EfCore.Models.Entities;

namespace EfCore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyContext _context;

        public CategoryController(MyContext context)
        {
            _context = context;
        }

        public IActionResult GetCategories()
        {
            return View(_context.Categories.ToList());
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCategory(Category item)
        {
            _context.Categories.Add(item);
            _context.SaveChanges();

            return RedirectToAction("GetCategories");
        }

        public IActionResult UpdateCategory(int id)
        {
            return View(_context.Categories.Find(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCategory(Category item)
        {
            Category original = _context.Categories.Find(item.ID);
            original.categoryName = item.categoryName;
            original.Description = item.Description;
            original.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("GetCategories");
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }

            return RedirectToAction("GetCategories");
        }



    }
}
