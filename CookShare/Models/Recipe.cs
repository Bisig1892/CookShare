using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookShare.Models
{

    /// <summary>
    /// A recipe to cook
    /// </summary>
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        /// <summary>
        /// Description of the recipe
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// name of the recipe
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Type of cuisine the recipe is(Asian, Indian, Mexican, etc.)
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Time taken to prepare ingredients before cooking
        /// </summary>
        public int PrepTime { get; set; }
        /// <summary>
        /// Cook time of the ingredients
        /// </summary>
        public int CookTime { get; set; }
        /// <summary>
        /// Servings the food makes
        /// </summary>
        public int Servings { get; set; }
        /// <summary>
        /// List of ingredients for the recipe
        /// </summary>
        public string Ingredients { get; set; }
        /// <summary>
        /// The directions to make the dish
        /// </summary>
        public string Instructions { get; set; }
    }
}
