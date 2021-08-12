using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Magazine
    {
        public Magazine()
        {
            Orders = new HashSet<Order>();
        }

        public int MagazineId { get; set; }
        public string MagazineName { get; set; }
        public int BuildingNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public virtual ICollection<Order> Orders { get; private set; }
    }
}
