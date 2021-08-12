using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ElectricScooterModel
    {
        public ElectricScooterModel()
        {
            Orders = new HashSet<Order>();
        }

        public int ElectricScooterId { get; set; }
        public string ScooterName { get; set; }
        public int EnginePower { get; set; }
        public int MaxSpeed { get; set; }
        public int RangeOnASingleCharge { get; set; }
        public double TheSizeOfTheWheels { get; set; }
        public int MaximumLoad { get; set; }
        public decimal ScooterPrice { get; set; }
        public int AvaliableScooterAmount { get; set; }
        public string ScooterAdditionalNotes { get; set; }

        public int AvaliableAmountId { get; set; }
        public virtual AvaliableAmount AvaliableAmount { get; set; }

        public virtual ICollection<Order> Orders { get; private set; }
    }
}
