using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookShare.Data;
using CookShare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            // Get recipe with corresponding id
            Recipe r = await _context.Recipes.Where(rec => rec.RecipeId == id).SingleAsync();

            // pass recipe to view
            return View(r);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Recipe r)
        {
            if(ModelState.IsValid)
            {
                _context.Entry(r).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(r);
        }
    }
}
