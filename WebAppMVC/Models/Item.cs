using System.ComponentModel;

namespace WebAppMVC.Models
{
    public class Item
    {
        public int Id { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }
        
        public string TypeId { get; set; }
    }
}
