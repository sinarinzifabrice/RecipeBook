using System;
using System.Collections.Generic;
using System.Linq;
using RecipeBook.ServiceLibrary.Entities;

namespace RecipeBook.ServiceLibrary.Domains
{
    public class Recipe
    {
        public void SaveRecipe(RecipeEntity recipeEntity)
		{
			// Validate some stuff

			var repository = new RecipeRepository();
			repository.SaveRecipeToDatabase(recipeEntity);
		}
    }
}