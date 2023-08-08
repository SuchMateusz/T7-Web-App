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
        public int AddItem(Item item);

        public void DeleteItem(int itemId);

        public Item GetItemByID(int itemId);

        public int AddIngredients(ItemIngredients ingredients);
        
        public void DeleteIngredients(int itemId);

        public ItemIngredients GetIngredientsById(int itemId);

        public IQueryable<ItemIngredients> GetItemAllIngredients();

        public int AddItemDescription(ItemDescription itemDescription);

        public IQueryable<ItemDescription> GetAllDescriptions();

        public int AddItemCategory(ItemCategory itemCategory);

        public IQueryable<ItemCategory> GetAllCategories();
    }
}
