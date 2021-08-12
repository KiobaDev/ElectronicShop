using Application.AvaliableAmountModel.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Helpers
{
    public interface IUnitOfWork :IDisposable
    {
        IAvaliableAmountRepository AvaliableAmountRepository { get; set; }
        void Save();
    }
}
