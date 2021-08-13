using Application.ElectricScooterModel.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ElectricScooterRepository : Repository<ElectricScooterModel>, IElectricScooterRepository
    {
        private readonly ApplicationDbContext _context;

        public ElectricScooterRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
