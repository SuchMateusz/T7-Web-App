﻿using System.ComponentModel;

namespace WebAppMVC.Domain.Model
{
    public class CustomerContactInformaction : EntityModel
    {
        [DisplayName("Last Name")]
        public string LastNameUser { get; set; }

        public string Position { get; set; }

        public int CustomerRef { get; set; }

        public Customer Customer { get; set; }
    }
}