using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppMVC.Domain.Model;

namespace WebAppMVC.Application.Interfaces
{
    public interface ICustomerRepository
    {
        public int AddCustomer(Customer customer);

        public void DeleteCustomer(int customerId);

        public IQueryable<ContactDetail> GetAllContactDetail();

        public IQueryable<ContactDetailType> GetAllContactDetailType();

        public IQueryable<CustomerContactInformaction> CustomerContactInformactions();

        public IQueryable<Address> Addresses();
    }
}
