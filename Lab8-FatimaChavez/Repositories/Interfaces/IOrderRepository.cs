using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;

namespace Lab8_FatimaChavez.Repositories.Interfaces;

public interface IOrderRepository
{
    Task<IEnumerable<string>> GetProductNamesSoldToClientAsync(int clientId);

    Task<IEnumerable<Order>> GetAfterDateAsync(DateTime date);

    Task<IEnumerable<ProductDetailDto>> GetProductDetailsByOrderIdAsync(int orderId);

    Task<int> GetTotalQuantityByOrderIdAsync(int orderId);

    Task<IEnumerable<OrderDetailSummaryDto>> GetAllSummariesAsync();

    Task<IEnumerable<OrderDetailsDto>> GetOrdersWithDetailsAsync();

    Task<IEnumerable<SalesByClientDto>> SalesbyClientsAsync();
    Task<ClientWithOrderCountDto?> GetClientWithMostOrdersAsync();



}