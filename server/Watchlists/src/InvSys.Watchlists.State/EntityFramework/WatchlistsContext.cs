﻿using InvSys.Watchlists.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace InvSys.Watchlists.State.EntityFramework
{
    public class WatchlistsContext : DbContext
    {
        private readonly IConfigurationRoot _config;

        public WatchlistsContext() { }

        public WatchlistsContext(IConfigurationRoot config, DbContextOptions options)
            : base(options)
        {
            _config = config;
        }

        public DbSet<Watchlist> Watchlists { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Watchlists;Integrated Security=SSPI;integrated security=true;MultipleActiveResultSets=True;");
            //optionsBuilder.UseSqlServer("Data Source=EPPLKATW0006\\SQLEXPRESS;Initial Catalog=Watchlists;User Id=sa;Password=TODO;MultipleActiveResultSets =True;");
            //optionsBuilder.UseSqlServer(_config["ConnectionStrings:WatchlistsContextConnection"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Watchlist>(ConfigureWatchlist);
            modelBuilder.Entity<WatchlistTranslation>(ConfigureWatchlistTranslation);
            modelBuilder.Entity<Item>(ConfigureItem);
        }

        private static void ConfigureWatchlist(EntityTypeBuilder<Watchlist> builder)
        {
            builder.HasMany(c => c.Translations).WithOne(t => t.Watchlist).HasForeignKey(t => t.WatchlistId)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
            builder.Property(c => c.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
            builder.HasMany(c => c.Items).WithOne(t => t.Watchlist).HasForeignKey(t => t.WatchlistId)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);
        }

        private static void ConfigureWatchlistTranslation(EntityTypeBuilder<WatchlistTranslation> builder)
        {
            builder.ToTable("WatchlistTranslations");
            builder.HasKey(t => new { t.WatchlistId, t.Culture });
            builder.Property(c => c.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
            builder.Property(c => c.Description).IsRequired().HasMaxLength(3000);
        }

        private static void ConfigureItem(EntityTypeBuilder<Item> builder)
        {
        }
    }
}
