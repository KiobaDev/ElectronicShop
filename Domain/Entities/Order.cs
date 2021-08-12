using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Order
    {
        public Order()
        {
            ElectricScooters = new HashSet<ElectricScooterModel>();
            OrderMagazines = new HashSet<OrderMagazine>();
        }

        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime Date { get; set; }

        public int MagazineId { get; set; }
        public virtual Magazine Magazine { get; set; }

        public virtual ICollection<ElectricScooterModel> ElectricScooters { get; private set; }
        public virtual ICollection<OrderMagazine> OrderMagazines { get; private set; }
    }
}
