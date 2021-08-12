using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DbInitializer
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElectricScooterModel>().HasData
            (
                new ElectricScooterModel
                {
                    ElectricScooterId = 1,
                    ScooterName = "FRUGAL Impulse",
                    EnginePower = 250,
                    MaxSpeed = 25,
                    RangeOnASingleCharge = 25,
                    TheSizeOfTheWheels = 8.5,
                    MaximumLoad = 100,
                    ScooterPrice=(decimal)999.99,
                    ScooterAdditionalNotes = "Impulse to hulajnoga elektryczna dla młodzieży i dorosłych. Waży 11,8kg posiada 8,5 calowe kola z " +
                                            "pompowanymi oponami, które gwarantują swobodę poruszania",
                    AvaliableAmountId = 1
                }
            );

            modelBuilder.Entity<AvaliableAmount>().HasData
            (
                new AvaliableAmount
                {
                    AvaliableAmountId = 1,
                    ElectricScooterId = 1,
                    Amount = 56
                }
            );
        }
    }
}
