using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppMVC.Domain.Model;
using Type = WebAppMVC.Domain.Model.Type;

namespace WebAppMVC.Application.Interfaces
{
    public interface IItemRepository
    {
        public void DeleteItem(int itemId);

        public int AddItem(Item item);

        public IQueryable<Item> GetItemByTypeId(int typeId);

        public Item GetItemByID(int itemId);

        public IQueryable<Tag> GetAllTags();

        public IQueryable<Type> GetAllTypes();
    }
}
