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

        //public int AddContactDetail(ContactDetail contactDetail);

        //public void DeleteContactDetail(ContactDetail contactDetail);

        //public int AddContactDetailType(ContactDetailType contactDetailType);

        //public void DeleteContactDetailType(ContactDetailType contactDetailType);
        
        //public IQueryable<ContactDetail> GetAllContactDetail();

        //public IQueryable<ContactDetailType> GetAllContactDetailType();

        public IQueryable<CustomerContactInformaction> GetCustomerContactInformactions();
        
        public int AddAddresses (Address address);

        public void DeleteAddresses (Address address);

        public IQueryable<Address> GetAddresses();
    }
}
