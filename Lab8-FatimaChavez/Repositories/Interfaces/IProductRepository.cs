using Lab8_FatimaChavez.Models;

namespace Lab8_FatimaChavez.Repositories.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetWithPriceGreaterThanAsync(decimal minPrice);

    Task<Product?> GetMostExpensiveAsync();

    Task<decimal> GetAveragePriceAsync();
    Task<IEnumerable<Product>> GetWithoutDescriptionAsync();
}