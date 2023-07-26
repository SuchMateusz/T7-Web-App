﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int TypeId { get; set; }

        public int Price { get; set; } 

        public virtual Type Type { get; set; }

        public virtual ICollection<ItemIngredients> ItemIngredients { get; set; }

        public virtual ICollection<ItemRecipe> ItemRecipe { get; set; }

        public ICollection<ItemTag> ItemTags { get; set; }
    }
}
