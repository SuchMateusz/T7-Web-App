using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
using System.Diagnostics;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Application.Services;

namespace WebAppMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult RecipeToCreateTheItem()
        {
            var recipeSteps = RecipeToCreateItem();
            return View(recipeSteps);
        }

        private List<RecipeToCreateItem> RecipeToCreateItem()
        {
            var items = new List<RecipeToCreateItem>();
            items.Add(new RecipeToCreateItem { ItemId = 1, Id = 1, StepOfRecipe = 1, Name = "Apple", NumberOfPiece = "0", NumberOfLiters = 10, RecipeDescripction = "Umyj jabłka, następnie rozdrobnij", Hours = 2 });
            items.Add(new RecipeToCreateItem { ItemId = 1, Id = 2, StepOfRecipe = 2, Name = "Water", NumberOfPiece = "0", NumberOfLiters = 5, RecipeDescripction = "Zagotuj wodę", Hours = 0.3M });
            items.Add(new RecipeToCreateItem { ItemId = 1, Id = 3, StepOfRecipe = 3, Name = "Sugar", NumberOfPiece = "6kg", NumberOfLiters = 0, RecipeDescripction = "Dodaj cukier do zagotowanej wody i czekaj aż uzyskasz jednolitą konsystencję", Hours = 0.6M });
            return (items);
        }
    }
}