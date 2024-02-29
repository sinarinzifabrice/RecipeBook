using System;
using System.Collections.Generic;
using System.Text;
using RecipeBook.ServiceLibrary.Entities;

namespace RecipeBook.ServiceLibrary;

public class Recipe
{
    public void SaveRecipe(RecipeEntity recipeEntity)
		{
			// Validate some stuff

			var repository = new RecipeRepository();
			repository.SaveRecipeToDatabase(recipeEntity);
		}
}
