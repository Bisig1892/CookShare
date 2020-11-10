using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookShare.Data;
using CookShare.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookShare.Controllers
{
    public class RecipeController : Controller
    {

        public readonly RecipeContext _context;

        public RecipeController(RecipeContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Displays a view that lists all recipes
        /// </summary>
        public IActionResult Index()
        {
            // Get all recipes from database
            List<Recipe> recipes = _context.Recipes.ToList();
            // Send list of recipes to view to be displayed
            return View(recipes);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Recipe r)
        {
            if(ModelState.IsValid)
            {
                _context.Recipes.Add(r);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
