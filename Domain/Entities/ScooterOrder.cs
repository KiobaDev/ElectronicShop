namespace Domain.Entities
{
    public class ScooterOrder
    {
        public int ElectricScooterId { get; set; }
        public virtual  ElectricScooterModel ElectricScooterModel { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
