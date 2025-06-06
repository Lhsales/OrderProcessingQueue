namespace OrderProcessing.Domain.Interfaces.Infrastructure
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        Task RollbackAsync();
    }
}
