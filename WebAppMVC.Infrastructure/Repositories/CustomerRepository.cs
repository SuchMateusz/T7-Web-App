using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Domain.Model;

namespace WebAppMVC.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;
        public CustomerRepository(Context context)
        {
            _context = context;
        }

        public int AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer.Id;
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == customerId);
            if(customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public IQueryable<ContactDetail> GetAllContactDetail()
        {
            var ContactDetail = _context.ContactDetails;
            return ContactDetail;
        }

        public IQueryable<ContactDetailType> GetAllContactDetailType()
        {
            var ContactDetailType = _context.ContactDetailTypes;
            return ContactDetailType;
        }

        public IQueryable<CustomerContactInformaction> GetCustomerContactInformactions()
        {
            var ContactInformaction = _context.CustomerContactInformactions;
            return ContactInformaction;
        }

        public int AddAddresses(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address.Id;
        }

        public void DeleteAddresses(Address address)
        {
            _context.Addresses.Remove(address);
            _context.SaveChanges();
        }

        public IQueryable<Address> GetAddresses()
        {
            var addresses = _context.Addresses;
            return addresses;
        }

        public int AddContactDetail(ContactDetail contactDetail)
        {
            _context.ContactDetails.Add(contactDetail);
            _context.SaveChanges();
            return contactDetail.Id;
        }

        public void DeleteContactDetail(ContactDetail contactDetail)
        {
            _context.ContactDetails.Remove(contactDetail);
            _context.SaveChanges();

        }

        public int AddContactDetailType(ContactDetailType contactDetailType)
        {
            _context.ContactDetailTypes.Add(contactDetailType);
            _context.SaveChanges();
            return contactDetailType.Id;
        }

        public void DeleteContactDetailType(ContactDetailType contactDetailType)
        {
            _context.ContactDetailTypes.Remove(contactDetailType);
            _context.SaveChanges();
        }


    }
}
