

namespace RecipeBook.ServiceLibrary;
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
