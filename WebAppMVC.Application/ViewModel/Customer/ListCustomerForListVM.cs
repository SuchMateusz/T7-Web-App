﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Application.ViewModel.Customer
{
    public class ListCustomerForListVM
    {
        public List<CustomerForListVM> Customers { get; set; }
        
        public int TotalCount { get; set; }
    }
}
