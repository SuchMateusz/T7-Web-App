using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class ItemIngredient : EntityModel
    {
        public int ItemIngredientsId { get; set; }

        public string NumberOfPiece { get; set; }

        public int NumberOfLiters { get; set; }
        
        public int ItemRef { get; set; }

        public Ingredient Ingredients { get; set; }

        public Item Item { get; set; }
    }
}
