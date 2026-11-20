using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;
using Lab8_FatimaChavez.Repositories.Interfaces;
using Lab8_FatimaChavez.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab8_FatimaChavez.Services.Implementations;

public class ProductsService : IProductsService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Product>> GetProductsWithPriceGreaterThanAsync(decimal minPrice)
    {
        return await _unitOfWork.Products.GetWithPriceGreaterThanAsync(minPrice);
    }

    public async Task<Product?> GetMostExpensiveProductAsync()
    {
        return await _unitOfWork.Products.GetMostExpensiveAsync();
    }

    public async Task<decimal> GetAverageProductPriceAsync()
    {
        return await _unitOfWork.Products.GetAveragePriceAsync();
    }

    public async Task<IEnumerable<Product>> GetProductsWithoutDescriptionAsync()
    {
        return await _unitOfWork.Products.GetWithoutDescriptionAsync();
    }

    public async Task<IEnumerable<string>> GetProductsSoldToClientAsync(int clientId)
    {
        return await _unitOfWork.Orders.GetProductNamesSoldToClientAsync(clientId);
    }
}