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

        }
    }
}
