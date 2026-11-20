using System.Collections;
using Lab8_FatimaChavez.Models;
using Lab8_FatimaChavez.Repositories.Interfaces;

namespace Lab8_FatimaChavez.Repositories.Implementations;

public class UnitOfWork : IUnitOfWork
{
    private Hashtable? _repositories;
    private readonly Lab08DbContext _context;
    
    public IProductRepository Products { get; }
    public IOrderRepository Orders { get; }
    public IClientRepository Clients { get; }

    public UnitOfWork(Lab08DbContext context)
    {
        _context = context;
        _repositories = new Hashtable();

        // --- AQUÍ SE ASIGNAN PARA QUE NO SEAN NULL ---
        Products = new ProductRepository(_context);
        Orders = new OrderRepository(_context);
    }

    public Task<int> Complete()
    {
        return _context.SaveChangesAsync();
    }

    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        var type = typeof(TEntity).Name;

        if (_repositories!.ContainsKey(type))
        {
            return (IGenericRepository<TEntity>)_repositories[type]!;
        }

        var repositoryType = typeof(GenericRepository<>);
        var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);

        if (repositoryInstance != null)
        {
            _repositories.Add(type, repositoryInstance);
            return (IGenericRepository<TEntity>)repositoryInstance;
        }

        throw new Exception($"Could not create repository instance for type {type}");
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}