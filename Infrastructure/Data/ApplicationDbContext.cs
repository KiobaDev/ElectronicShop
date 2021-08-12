using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuildier)
        {
            optionsBuildier.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuildier);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            var init = new DbInitializer();
                init.Seed(modelBuilder);

            modelBuilder.Entity<ElectricScooterModel>().HasKey(key => key.ElectricScooterId);

            modelBuilder.Entity<OrderMagazine>().HasKey(sc => new { sc.OrderId, sc.MagazineId });
            
            modelBuilder.Entity<AvaliableAmount>()
            .HasOne<ElectricScooterModel>(s => s.ElectricScooter)
            .WithOne(ad => ad.AvaliableAmount)
            .HasForeignKey<ElectricScooterModel>(ad => ad.ElectricScooterId);

            modelBuilder.Entity<ElectricScooterModel>()
            .HasOne<AvaliableAmount>(s => s.AvaliableAmount)
            .WithOne(ad => ad.ElectricScooter)
            .HasForeignKey<AvaliableAmount>(ad => ad.AvaliableAmountId);

            modelBuilder.Entity<OrderMagazine>()
            .HasOne<Magazine>(sc => sc.Magazine)
            .WithMany(s => s.OrderMagazines)
            .HasForeignKey(sc => sc.MagazineId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderMagazine>()
            .HasOne<Order>(sc => sc.Order)
            .WithMany(s => s.OrderMagazines)
            .HasForeignKey(sc => sc.OrderId)
            .OnDelete(DeleteBehavior.Restrict); ;
        }

        public DbSet<AvaliableAmount> AvaliableAmounts { get; set; }
        public DbSet<ElectricScooterModel> ElectricScooterModels { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderMagazine> OrderMagazines { get; set; }
    }
}
