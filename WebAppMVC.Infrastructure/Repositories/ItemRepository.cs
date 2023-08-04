using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC.Application.Interfaces;
using WebAppMVC.Domain.Model;
using Type = WebAppMVC.Domain.Model.Type;

namespace WebAppMVC.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if(item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }

        public int AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public IQueryable<Item> GetItemByTypeId(int typeId)
        {
            var items = _context.Items.Where(i => i.TypeId == typeId);
            return items;
        }

        public Item GetItemByID(int itemId)
        {
            //_context.Items.Where(i => i.Id == itemId).FirstOrDefault;
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }

        public IQueryable<ItemIngredients> GetItemAllIngredients()
        {
            var ingredients = _context.ItemIngredients;
            return ingredients;
        }

        public IQueryable<ItemDescription> GetAllDescriptions()
        {
            var recipes = _context.ItemDescriptions;
            return recipes;
        }

        public int AddItemCategory(ItemCategory itemCategory)
        {
            _context.ItemCategories.Add(itemCategory);
            _context.SaveChanges();
            return itemCategory.Id;
        }

        public int AddItemDescription(ItemDescription itemDescription)
        {
            _context.ItemDescriptions.Add(itemDescription);
            _context.SaveChanges();
            return itemDescription.Id;
        }

        public IQueryable<ItemCategory> GetAllCategories()
        {
            var categories = _context.ItemCategories;
            return categories;
        }
    }
}