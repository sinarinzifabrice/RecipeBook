using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RecipeBook.Controllers
{
    [Route("[controller]")]
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