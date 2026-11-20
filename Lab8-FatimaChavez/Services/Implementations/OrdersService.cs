using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;
using Lab8_FatimaChavez.Repositories.Interfaces;
using Lab8_FatimaChavez.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab8_FatimaChavez.Services.Implementations;

public class OrdersService : IOrdersService
{
    private readonly IUnitOfWork _unitOfWork;

    public OrdersService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<ProductDetailDto>> GetProductDetailsByOrderIdAsync(int orderId)
    {
        return await _unitOfWork.Orders.GetProductDetailsByOrderIdAsync(orderId);
    }

    public async Task<int> GetTotalProductQuantityByOrderIdAsync(int orderId)
    {
        return await _unitOfWork.Orders.GetTotalQuantityByOrderIdAsync(orderId);
    }

    public async Task<IEnumerable<Order>> GetOrdersAfterDateAsync(DateTime date)
    {
        return await _unitOfWork.Orders.GetAfterDateAsync(date);
    }

    public async Task<IEnumerable<OrderDetailSummaryDto>> GetAllOrdersAndDetailsAsync()
    {
        return await _unitOfWork.Orders.GetAllSummariesAsync();
    }
    
    public async Task<IEnumerable<OrderDetailsDto>> GetOrdersWithDetailsAsync()
    {
        return await _unitOfWork.Orders.GetOrdersWithDetailsAsync();
    }
    public async Task<IEnumerable<SalesByClientDto>> GetSalesByClientAsync()
    {
        return await _unitOfWork.Orders.SalesbyClientsAsync();
    }
}