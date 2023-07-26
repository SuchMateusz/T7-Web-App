using System.ComponentModel;

namespace WebAppMVC.Models
{
    public class ItemIngredients : Item
    {
        public int ItemId { get; set; }

        public string NumberOfPiece { get; set; }

        public int NumberOfLiters { get; set; }
    }
}