﻿using System;
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

        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
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

        public int AddItemIngredients(ItemIngredient ingredients)
        {
            _context.ItemIngredients.Add(ingredients);
            _context.SaveChanges();
            return ingredients.Id;
        }

        public void DeleteItemIngredients(int itemId)
        {
            var item = _context.ItemIngredients.Find(itemId);
            if (item != null)
            {
                _context.ItemIngredients.Remove(item);
                _context.SaveChanges();
            }
        }

        public IQueryable<ItemIngredient> GetAllItemIngredients()
        {
            var ingredients = _context.ItemIngredients;
            return ingredients;
        }

        public ItemIngredient GetItemIngredientsById(int itemId)
        {
            var ingredients = _context.ItemIngredients.Find(itemId);
            return ingredients;
        }

        public int AddIngredients (Ingredient ingredient)
        {
            _context.Ingredients.Add(ingredient);
            _context.SaveChanges();
            return ingredient.Id;
        }

        public void DeleteIngredients(int ingredientId)
        {
            var ingredient = _context.Ingredients.Find(ingredientId);
            if (ingredient != null)
            {
                _context.Ingredients.Remove(ingredient);
                _context.SaveChanges();
            }
        }

        public Ingredient GetIngredientById(int ingredientId)
        {
            var ingredient = _context.Ingredients.Find (ingredientId);
            return ingredient;
        }

        public IQueryable<Ingredient> GetAllIngredients()
        {
            var ingredients = _context.Ingredients;
            return ingredients;
        }
    }
}