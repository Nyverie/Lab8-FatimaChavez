using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;

namespace Lab8_FatimaChavez.Services.Interfaces;

public interface IClientsService
{

    Task<IEnumerable<Client>> GetClientsByNameAsync(string name);


    Task<ClientWithOrderCountDto?> GetClientWithMostOrdersAsync();
    
    Task<IEnumerable<string>> GetClientsWhoBoughtProductAsync(int productId);
    
    Task<IEnumerable<ClientOrderDto>> GetClientsWithOrdersAsync();
    
    Task<IEnumerable<object>> GetClientsWithProductCountAsync();
    
}
