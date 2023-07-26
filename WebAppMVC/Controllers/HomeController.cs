using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Application.Services;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IItemService _itemService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_itemService = itemService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ViewListOfItems()
        {
            List<Item> listOfItems = CreateNewListOfItems();
            return View(listOfItems);
        }

        public IActionResult ViewDetailsOfItem(int itemId)
        {
            List<ItemIngredients> itemsDesc = ItemDesc();
            var itemDetails = itemsDesc.FindAll(p => p.ItemId == itemId);
            return View(itemDetails);
        }

        private List<ItemIngredients> ItemDesc()
        {
            var itemsDesc = new List<ItemIngredients>();
            itemsDesc.Add(new ItemIngredients { ItemId = 1, Id = 1, Name = "Apple", NumberOfPiece = "0", NumberOfLiters = 10 });
            itemsDesc.Add(new ItemIngredients { ItemId = 1, Id = 2, Name = "Water", NumberOfPiece = "0", NumberOfLiters = 5 });
            itemsDesc.Add(new ItemIngredients { ItemId = 1, Id = 3, Name = "Sugar", NumberOfPiece = "6kg", NumberOfLiters = 0 });

            itemsDesc.Add(new ItemIngredients { ItemId = 2, Id = 1, Name = "Blueberry", NumberOfPiece = "10kg", NumberOfLiters = 0, });
            itemsDesc.Add(new ItemIngredients { ItemId = 2, Id = 2, Name = "Water", NumberOfPiece = "0", NumberOfLiters = 5 });
            itemsDesc.Add(new ItemIngredients { ItemId = 2, Id = 3, Name = "Sugar", NumberOfPiece = "5kg", NumberOfLiters = 0 });

            itemsDesc.Add(new ItemIngredients { ItemId = 3, Id = 1, Name = "Apple", NumberOfLiters = 10 });
            itemsDesc.Add(new ItemIngredients { ItemId = 3, Id = 2, Name = "Water", NumberOfLiters = 5 });
            itemsDesc.Add(new ItemIngredients { ItemId = 3, Id = 3, Name = "Sugar", NumberOfLiters = 6 });
            return itemsDesc;
        }

        private List<Item> CreateNewListOfItems()
        {
            var items = new List<Item>();
            items.Add(new Item { Id = 1, Name = "Apple", TypeId = "1. Sweet" });
            items.Add(new Item { Id = 2, Name = "Blueberry", TypeId = "2. half sweet" });
            items.Add(new Item { Id = 3, Name = "Apple", TypeId = "1. Sweet" });
            return items;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}