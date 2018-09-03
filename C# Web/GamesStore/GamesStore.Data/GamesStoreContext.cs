using System;
using GamesStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Data
{
    public class GamesStoreContext : IdentityDbContext<User>
    {
        public GamesStoreContext(DbContextOptions<GamesStoreContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

        public DbSet<PendingOrder> PendingOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .Entity<Game>()
                .HasOne(x => x.Category)
                .WithMany(x => x.Games)
                .HasForeignKey(x => x.CategoryId);

            base.OnModelCreating(builder);
        }
    }
}
