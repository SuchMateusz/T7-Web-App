using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class ItemIngredients : EntityModel
    {
        public string NumberOfPiece { get; set; }

        public int NumberOfLiters { get; set; }
        
        public int ItemRef { get; set; }

        public virtual Item Item { get; set; }
    }
}
