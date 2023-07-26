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

        public string NIP { get; set; }

        public CustomerContactInformaction CustomerContactInformaction { get; set; }

        public virtual ICollection<ContactDetail> ContactDetails { get; set; } 

        public Address AddressDetails { get; set; }
    }
}
