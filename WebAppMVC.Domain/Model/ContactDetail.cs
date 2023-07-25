using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppMVC.Domain.Model
{
    public class ContactDetail
    {
        public int Id { get; set; }

        public string ContactDetailInformaction { get; set; }

        public int ContactDetailTypeId { get; set; }

        public ContactDetailType contactDetailType { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
