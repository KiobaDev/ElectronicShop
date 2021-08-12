using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DbInitializer
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "TV"
            },
            new Product
            {
                ProductId = 2,
                Name = "Mikrofala"
            },
            new Product
            {
                ProductId = 3,
                Name = "Toster"
            },
            new Product
            {
                ProductId = 4,
                Name = "Odkurzacz"
            });
        }
    }
}
