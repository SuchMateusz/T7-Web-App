using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Users
    {
        [Key]
        public int IdCustomer { get; set; }

        [DisplayName("Login")]
        public string NameCustomer { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public int PhoneNumber { get; set; }
    }
}