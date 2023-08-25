using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Application.ViewModel.Customer;

namespace WebAppMVC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public int AddAddressModel(AddressForListVM address)
        {
            throw new NotImplementedException();
        }

        public int AddCustomer(NewCustomerVM customer)
        {
            throw new NotImplementedException();
        }

        public int AddCustomerContactInformaction(CustomerContactInformactionForListVm custContactDetail)
        {
            throw new NotImplementedException();
        }

        public AddressForListVM GetAddressCustomerDetails(int customerId)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVM GetAllCustomerForList()
        {
            var customers = _customerRepo.GetAllActiveCustomers();
            ListCustomerForListVM result = new ListCustomerForListVM();
            result.Customers = new List<CustomerForListVM>();
            foreach (var customer in customers)
            {
                var custVM = new CustomerForListVM()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    NIP = customer.NIP,
                };
                result.Customers.Add(custVM);
            }
            result.TotalCount = result.Customers.Count;
            return result;
        }

        public CustomerDetailsVM GetCustomerDetails(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
