using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Order
    {
        public Order()
        {
            ScooterOrders = new HashSet<ScooterOrder>();
        }

        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public DateTime Date { get; set; }

        public int MagazineId { get; set; }
        public virtual Magazine Magazine { get; set; }

        public virtual ICollection<ScooterOrder> ScooterOrders { get; set; }
    }
}
