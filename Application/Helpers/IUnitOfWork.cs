using Application.AvaliableAmountModel.Interface;
using Application.ElectricScooterModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Helpers
{
    public interface IUnitOfWork :IDisposable
    {
        IAvaliableAmountRepository AvaliableAmountRepository { get; set; }
        IElectricScooterRepository ElectricScooterRepository { get; set; }
        void Save();
    }
}
