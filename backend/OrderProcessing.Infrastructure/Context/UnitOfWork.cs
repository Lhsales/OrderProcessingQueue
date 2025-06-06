using OrderProcessing.Domain.Interfaces.Infrastructure;

namespace OrderProcessing.Infrastructure.Context
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task CommitAsync() => await _context.SaveChangesAsync();
        public async Task RollbackAsync() => await Task.CompletedTask;
    }
}
