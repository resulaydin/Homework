using GameManagerSystem.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagerSystem.DataAccess.Concrete.Databasess
{
    public class CampDatabaseContext : DbContext
    {

        public DbSet<Game> Games { get; set; }
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)
                .UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
            // base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().Property(x => x.Discount).HasPrecision(5, 2);
            modelBuilder.Entity<OrderDetail>().Property(x => x.UnitPrice).HasPrecision(5, 2);
            modelBuilder.Entity<Game>().Property(x => x.UnitPrice).HasPrecision(5, 2);
            modelBuilder.Entity<Campaign>().Property(x => x.DiscountPercentage).HasPrecision(5, 2);
            modelBuilder.Entity<Campaign>().Property(x => x.DiscountPercentage).HasPrecision(5, 2);
            modelBuilder.Entity<Campaign>().Property(x => x.DiscountPercentage).HasDefaultValue(0);
            modelBuilder.Entity<OrderDetail>().Property(x => x.Discount).HasDefaultValue(0);

            base.OnModelCreating(modelBuilder);
        }

    }
}
