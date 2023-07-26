using System.ComponentModel;

namespace WebAppMVC.Domain.Model
{
    public class CustomerContactInformaction
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        public string NameUser { get; set; }

        [DisplayName("Surname")]
        public string LastNameUser { get; set; }

        public int CustomerRef { get; set; }

        public Customer Customer { get; set; }
    }
}