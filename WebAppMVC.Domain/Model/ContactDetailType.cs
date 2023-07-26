using System.Collections.Generic;

namespace WebAppMVC.Domain.Model
{
    public class ContactDetailType
    {
        public int Id { get; set; }
        //Email & telefon & rodzaj kontaktu
        public string Name { get; set; }

        public ICollection<ContactDetail> ContactDetails { get; set; }
    }
} 