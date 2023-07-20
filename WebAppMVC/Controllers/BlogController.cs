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

        public IActionResult RecipeHowToCreateItemById(int id)
        {
            var allRecipeSteps = RecipeToCreateItem();
            var recipeSteps = allRecipeSteps.FindAll(x => x.ItemId == id);
            return View(recipeSteps);
        }

        private List<RecipeToCreateItem> RecipeToCreateItem()
        {
            var items = new List<RecipeToCreateItem>();
            items.Add(new RecipeToCreateItem { ItemId = 1, Id = 1, StepOfRecipe = 1, Name = "Apple", NumberOfPiece = "0", NumberOfLiters = 10, RecipeDescripction = "Umyj jabłka, następnie rozdrobnij", Hours = 2 });
            items.Add(new RecipeToCreateItem { ItemId = 1, Id = 2, StepOfRecipe = 2, Name = "Water", NumberOfPiece = "0", NumberOfLiters = 5, RecipeDescripction = "Zagotuj wodę", Hours = 0.3M });
            items.Add(new RecipeToCreateItem { ItemId = 1, Id = 3, StepOfRecipe = 3, Name = "Sugar", NumberOfPiece = "6kg", NumberOfLiters = 0, RecipeDescripction = "Dodaj cukier do zagotowanej wody i czekaj aż uzyskasz jednolitą konsystencję", Hours = 0.6M });

            items.Add(new RecipeToCreateItem { ItemId = 2, Id = 1, StepOfRecipe = 1, Name = "Strawberry", NumberOfPiece = "15", NumberOfLiters = 0, RecipeDescripction = "Umyć truskawki", Hours = 5 });
            items.Add(new RecipeToCreateItem { ItemId = 2, Id = 2, StepOfRecipe = 2, Name = "Water", NumberOfPiece = "0", NumberOfLiters = 5, RecipeDescripction = "Zagotuj wodę", Hours = 0.3M });
            items.Add(new RecipeToCreateItem { ItemId = 2, Id = 3, StepOfRecipe = 3, Name = "Sugar", NumberOfPiece = "4kg", NumberOfLiters = 0, RecipeDescripction = "Dodaj cukier do zagotowanej wody i czekaj aż uzyskasz jednolitą konsystencję", Hours = 0.6M });

            items.Add(new RecipeToCreateItem { ItemId = 3, Id = 1, StepOfRecipe = 1, Name = "Wi", NumberOfPiece = "0", NumberOfLiters = 10, RecipeDescripction = "Umyj jabłka, następnie rozdrobnij", Hours = 3 });
            items.Add(new RecipeToCreateItem { ItemId = 3, Id = 2, StepOfRecipe = 2, Name = "Water", NumberOfPiece = "0", NumberOfLiters = 5, RecipeDescripction = "Zagotuj wodę", Hours = 0.3M });
            items.Add(new RecipeToCreateItem { ItemId = 3, Id = 3, StepOfRecipe = 3, Name = "Sugar", NumberOfPiece = "6kg", NumberOfLiters = 0, RecipeDescripction = "Dodaj cukier do zagotowanej wody i czekaj aż uzyskasz jednolitą konsystencję", Hours = 0.6M });
            items.Add(new RecipeToCreateItem { ItemId = 3, Id = 4, StepOfRecipe = 3, Name = "Sugar", NumberOfPiece = "6kg", NumberOfLiters = 0, RecipeDescripction = "Dodaj cukier do zagotowanej wody i czekaj aż uzyskasz jednolitą konsystencję", Hours = 0.6M });

            return (items);
        }
    }
}