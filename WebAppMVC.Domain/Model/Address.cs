﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class Address
    {
        public int Id { get; set; }

        public string BuildingNumber { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        //public int AddressCountryTypeId { get; set; }
        //public virutal AddressCountryTypeId { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
