using Microsoft.EntityFrameworkCore;
using CosmoStore.Domain.Models;

namespace CosmoStore.Infra.Data
{
    internal sealed class AppDbContext(DbContextOptions opts):DbContext(opts)
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Studio> Studios { get; set; }

        public DbSet<UserInventory> UserInventory { get; set; }

        public DbSet<UserLibrary> UserLibrary { get; set; }

        public DbSet<UserWishList> UserWishList { get; set; }

       
    }
}
