using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;

namespace Lab8_FatimaChavez.Services.Interfaces;

public interface IProductsService
{

    Task<IEnumerable<Product>> GetProductsWithPriceGreaterThanAsync(decimal minPrice);


    Task<Product?> GetMostExpensiveProductAsync();


    Task<decimal> GetAverageProductPriceAsync();

   
    Task<IEnumerable<Product>> GetProductsWithoutDescriptionAsync();

    Task<IEnumerable<string>> GetProductsSoldToClientAsync(int clientId);
}
