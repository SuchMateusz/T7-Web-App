﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC.Application.ViewModel.Customer;

namespace WebAppMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVM GetAllCustomerForList();

        int AddCustomer (NewCustomerVM customer);

        int AddAddressModel (AddressForListVM address);

        AddressForListVM GetAddressCustomerDetails(int customerId);

        int AddCustomerContactInformaction(CustomerContactInformactionForListVm custContactDetail);

        CustomerDetailsVM GetCustomerDetails(int  customerId);
    }
}
