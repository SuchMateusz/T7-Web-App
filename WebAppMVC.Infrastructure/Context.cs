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

        public DbSet<CustomerContactInformaction> CustomerContactInformactions { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ItemIngredients> ItemIngredients { get; set; }

        public DbSet<ItemRecipe> ItemRecipes { get; set; }

        public DbSet<ItemTag> ItemTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Domain.Model.Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformaction).WithOne(b => b.Customer)
                .HasForeignKey<CustomerContactInformaction>(e => e.CustomerRef);

            builder.Entity<Customer>()
                .HasOne(a => a.AddressDetails).WithOne(b => b.Customer)
                .HasForeignKey<Address>(e => e.CustomerId);

            builder.Entity<ContactDetail>()
                .HasKey(it => new { it.ContactDetailTypeId, it.CustomerId });

            builder.Entity<ContactDetail>()
                .HasOne<ContactDetailType> (it => it.ContactDetailType)
                .WithMany(i => i.ContactDetails)
                .HasForeignKey(it => it.ContactDetailTypeId);

            builder.Entity<ContactDetail>()
                .HasOne<Customer>(it => it.Customer)
                .WithMany(i => i.ContactDetails)
                .HasForeignKey(it => it.CustomerId);

            builder.Entity<ItemTag>()
                .HasKey(it => new { it.ItemId, it.TagId });

            builder.Entity<ItemTag>()
                .HasOne<Item>(it => it.Item)
                .WithMany(i => i.ItemTags)
                .HasForeignKey(it => it.ItemId);

            builder.Entity<ItemTag>()
                .HasOne<Tag> (it => it.Tag)
                .WithMany(t=>t.ItemTags)
                .HasForeignKey(it => it.TagId);
        }
    }
}
