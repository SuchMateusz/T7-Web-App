﻿using System;
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

        public int AddCustomerContactInformaction(CustomerContactInformaction customerContactInformaction)
        {
            _context.CustomerContactInformactions.Add(customerContactInformaction);
            _context.SaveChanges();
            return customerContactInformaction.Id;
        }

        public void DeleteCustomerContactInformaction(int customerContactInformactionId)
        {
            var customerContactInformaction = _context.CustomerContactInformactions.Find(customerContactInformactionId);
            _context.CustomerContactInformactions.Remove(customerContactInformaction);
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

        public IQueryable<Customer> GetAllActiveCustomers()
        {
            var customers = _context.Customers;
            return customers;
        }
    }
}
