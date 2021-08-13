using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Application.AvaliableAmountModel.ViewModels
{
    public class AvaliableAmountIndexViewModel
    {
        public int ScooterId { get; set; }
        public int AddingAmount { get; set; }
        public IEnumerable<Domain.Entities.ElectricScooterModel> Scooters { get; set; }
    }
}
