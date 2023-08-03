using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppMVC.Domain.Model
{
    public class ItemCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ItemRef { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
