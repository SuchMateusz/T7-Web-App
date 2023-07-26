using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class ItemIngredients
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NumberOfPiece { get; set; }

        public int NumberOfLiters { get; set; }
        
        public int ItemRef { get; set; }

        public virtual Item Item { get; set; }
    }
}
