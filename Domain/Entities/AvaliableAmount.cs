using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class AvaliableAmount
    {
        public int AvaliableAmountId { get; set; }
        public int Amount { get; set; }
        
        public int ElectricScooterId { get; set; }
        public virtual ElectricScooterModel ElectricScooter { get; set; }
    }
}
