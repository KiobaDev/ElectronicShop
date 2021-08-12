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
            
            modelBuilder.Entity<AvaliableAmount>()
            .HasOne<ElectricScooterModel>(s => s.ElectricScooter)
            .WithOne(ad => ad.AvaliableAmount)
            .HasForeignKey<ElectricScooterModel>(ad => ad.ElectricScooterId);

            modelBuilder.Entity<ElectricScooterModel>()
            .HasOne<AvaliableAmount>(s => s.AvaliableAmount)
            .WithOne(ad => ad.ElectricScooter)
            .HasForeignKey<AvaliableAmount>(ad => ad.AvaliableAmountId);

            modelBuilder.Entity<ScooterOrder>().HasKey(t => new { t.ElectricScooterId, t.OrderId });

            modelBuilder.Entity<ScooterOrder>()
            .HasOne(t => t.Order)
            .WithMany(t => t.ScooterOrders)
            .HasForeignKey(t => t.OrderId);

            modelBuilder.Entity<ScooterOrder>()
                        .HasOne(t => t.ElectricScooterModel)
                        .WithMany(t => t.ScooterOrders)
                        .HasForeignKey(t => t.ElectricScooterId);
        }
    }
}
