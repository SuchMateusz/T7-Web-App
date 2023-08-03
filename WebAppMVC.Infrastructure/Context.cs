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

        public DbSet<ItemDescription> ItemDescriptions { get; set; }

        public DbSet<ItemTag> ItemTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Domain.Model.Type> Types { get; set; }

        public Context(DbContextOptions options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //1 do 1
            builder.Entity<Customer>()
                .HasOne(a => a.CustomerContactInformaction).WithOne(b => b.Customer)
                .HasForeignKey<CustomerContactInformaction>(e => e.CustomerRef);

            //1 do wielu?? wiele do 1?
            builder.Entity<Customer>()
                .HasMany<Address>(it => it.AddressDetails)
                .WithOne(b => b.Customer)
                .HasForeignKey(e => e.CustomerId);

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

            //1 do wielu
            builder.Entity<ItemTag>()
                .HasOne<Tag> (it => it.Tag)
                .WithMany(t=>t.ItemTags)
                .HasForeignKey(it => it.TagId);

            //wiele składników ma jednego itema. wiele do 1
            builder.Entity<Item>()
                .HasMany<ItemIngredients>(it => it.ItemIngredients)
                .WithOne(b => b.Item)
                .HasForeignKey(e => e.ItemRef);

            //1 do 1
            builder.Entity<Item>()
                .HasOne(a => a.ItemDescription)
                .WithOne(b => b.Item)
                .HasForeignKey<ItemDescription>(it => it.ItemRef);

            //1 do wielu.
            builder.Entity<Item>()
                .HasOne<ItemCategory>(it => it.ItemCategory)
                .WithMany(i => i.Items)
                .HasForeignKey(it => it.ItemCategoryId);

            builder.Entity<Item>()
                .HasOne<Domain.Model.Type>(it => it.Type)
                .WithMany(it => it.Items)
                .HasForeignKey(it => it.TypeId);
        }
    }
}
