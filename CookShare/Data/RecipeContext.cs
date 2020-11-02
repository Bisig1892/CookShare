using System;
using System.Collections.Generic;
using System.Text;
using CookShare.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CookShare.Data
{
    public class RecipeContext : IdentityDbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
