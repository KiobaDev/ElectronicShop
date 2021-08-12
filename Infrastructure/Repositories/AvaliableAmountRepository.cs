using Application.AvaliableAmountModel.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class AvaliableAmountRepository : Repository<AvaliableAmount>, IAvaliableAmountRepository
    {
        private readonly ApplicationDbContext _context;

        public AvaliableAmountRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }
    }
}
