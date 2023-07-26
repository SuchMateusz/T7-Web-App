﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class ItemTag
    {
        //Tabela pomocnicza,

        //klucze obce do tabel które chce powiązać
        public int ItemId { get; set; }

        public int TagId { get; set; }

        public Item Item { get; set; }

        public Tag Tag { get; set; }

    }
}
