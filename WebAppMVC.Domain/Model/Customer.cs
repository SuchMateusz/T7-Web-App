using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Login")]
        public string LoginCustomer { get; set; }

        public string Password { get; set; }

        [DisplayName("Name")]
        public string NameUser { get; set; }

        [DisplayName("Surname")]
        public string LastNameUser { get; set; }

        public CustomerContactInformaction CustomerContactInformaction { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; } 

        public virtual ICollection<Address> AddressDetails { get; set; }
    }
}
