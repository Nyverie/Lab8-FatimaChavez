
namespace Lab8_FatimaChavez.Repositories.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;

    IProductRepository Products { get; }
    IOrderRepository Orders { get; }
    IClientRepository Clients { get; }

    Task<int> Complete();
}