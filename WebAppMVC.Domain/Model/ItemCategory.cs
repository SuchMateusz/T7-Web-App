﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Domain.Model
{
    public class ItemCategory : EntityModel
    {
        public ICollection<Item> Items { get; set; }
    }
}
