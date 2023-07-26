using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppMVC.Domain.Model;

namespace WebAppMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }

        public DbSet<ContactDetail> ContactDetails { get; set; }

        public DbSet<ContactDetailType> ContactDetailTypes { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerContactInformaction> customerContactInformactions { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ItemIngredients> ItemIngredients { get; set; }

        public DbSet<ItemRecipe> ItemRecipes { get; set; }  



        //public DbSet<WebAppMVC.Domain.Model.Type>

        public Context(DbContextOptions options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformaction).WithOne(b => b.Customer)
                .HasForeignKey<CustomerContactInformaction>(e => e.CustomerRef);
        }
    }
}
