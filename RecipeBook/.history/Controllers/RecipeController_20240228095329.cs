using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.ServiceLibrary.Ent;

namespace RecipeBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
		public IActionResult AddNewRecipe([FromQuery]RecipeEntity recipeEntity)
		{
			var businessLogic = new Recipe();
			businessLogic.SaveRecipe(recipeEntity);
			return Ok();
		}
    }
}