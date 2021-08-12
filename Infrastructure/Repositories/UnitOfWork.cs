using Application.AvaliableAmountModel.Interface;
using Application.Helpers;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
            this.AvaliableAmountRepository = new AvaliableAmountRepository(context);
        }
        public IAvaliableAmountRepository AvaliableAmountRepository { get; set; }

        public void Dispose()
        {
            _context.DisposeAsync();
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }
    }
}
