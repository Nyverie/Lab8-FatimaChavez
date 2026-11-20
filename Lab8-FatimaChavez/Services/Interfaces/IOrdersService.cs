using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;
using Lab8_FatimaChavez.Controllers;
using Lab8_FatimaChavez.Services.Interfaces;
namespace Lab8_FatimaChavez.Services.Interfaces;

public interface IOrdersService
{

    Task<IEnumerable<ProductDetailDto>> GetProductDetailsByOrderIdAsync(int orderId);

    Task<int> GetTotalProductQuantityByOrderIdAsync(int orderId);


    Task<IEnumerable<Order>> GetOrdersAfterDateAsync(DateTime date);

    Task<IEnumerable<OrderDetailSummaryDto>> GetAllOrdersAndDetailsAsync();
    
    Task<IEnumerable<OrderDetailsDto>> GetOrdersWithDetailsAsync();
    Task<IEnumerable<SalesByClientDto>> GetSalesByClientAsync();
}
