using Application.AvaliableAmountModel.Interface;
using Application.ElectricScooterModel.Interface;
using Application.Helpers;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data
{
    public class ServicesDIContainer
    {
        IServiceCollection _services;
        public ServicesDIContainer(IServiceCollection services)
        {
            this._services = services;
        }
        public void ServicesDI()
        {
            this._services.AddScoped<IUnitOfWork, UnitOfWork>();
            this._services.AddScoped<IAvaliableAmountRepository, AvaliableAmountRepository>();
            this._services.AddScoped<IElectricScooterRepository, ElectricScooterRepository>();
        }
    }
}
