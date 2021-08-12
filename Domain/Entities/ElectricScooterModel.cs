using System.Collections.Generic;

namespace Domain.Entities
{
    public class ElectricScooterModel
    {
        public ElectricScooterModel()
        {
            ScooterOrders = new HashSet<ScooterOrder>();
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

        public virtual ICollection<ScooterOrder> ScooterOrders { get; set; }
    }
}
