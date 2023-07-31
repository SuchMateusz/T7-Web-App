﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC.Domain.Model;

namespace WebAppMVC.Infrastructure.Repositories
{
    public class CustomerRepository
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

        public IQueryable<CustomerContactInformaction> customerContactInformactions()
        {
            var ContactInformaction = _context.CustomerContactInformactions;
            return ContactInformaction;
        }

        public IQueryable<Address> Addresses()
        {
            var addresses = _context.Addresses;
            return addresses;
        }
    }
}
