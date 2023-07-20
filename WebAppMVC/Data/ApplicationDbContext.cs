using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppMVC.Models;

namespace WebAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebAppMVC.Models.Item> Item { get; set; } = default!;
        public DbSet<WebAppMVC.Models.ItemIngredients> ItemIngredients { get; set; } = default!;
        public DbSet<WebAppMVC.Models.RecipeToCreateItem> RecipeToCreateItem { get; set; } = default!;
        public DbSet<WebAppMVC.Models.Users> Wines { get; set; } = default!;
    }
}