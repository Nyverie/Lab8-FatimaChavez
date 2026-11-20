using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;

namespace Lab8_FatimaChavez.Repositories.Interfaces;

public interface IClientRepository
{
    Task<IEnumerable<Client>> GetByNameAsync(string name);
    Task<IEnumerable<string>> GetClientsWhoBoughtProductAsync(int productId);
    Task<IEnumerable<ClientOrderDto>> GetClientsWithOrdersAsync();
    Task<IEnumerable<object>> GetClientsWithProductCountAsync();
}