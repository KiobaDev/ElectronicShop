namespace Domain.Entities
{
    public class OrderMagazine
    {
        public int MagazineId { get; set; }
        public virtual  Magazine Magazine { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
