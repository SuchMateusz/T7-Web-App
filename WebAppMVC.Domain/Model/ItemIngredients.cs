﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class ItemIngredients : Item
    {
        public int Id { get; set; }

        public string NumberOfPiece { get; set; }

        public int NumberOfLiters { get; set; }
    }
}
