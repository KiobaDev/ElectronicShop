

using Application.AvaliableAmountModel.ViewModels;
using Application.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AvaliableAmountController : Controller
    {
        private readonly IUnitOfWork _UoW;
        public AvaliableAmountController(IUnitOfWork UoW)
        {
            this._UoW = UoW;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new AvaliableAmountIndexViewModel();

            model.Scooters = _UoW.ElectricScooterRepository.GetAll();

            return View(model);
        }
    }
}
