using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;
using Lab8_FatimaChavez.Repositories.Interfaces;
using Lab8_FatimaChavez.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab8_FatimaChavez.Services.Implementations;

public class ClientsService : IClientsService
{
    private readonly IUnitOfWork _unitOfWork;

    public ClientsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Client>> GetClientsByNameAsync(string name)
    {
        return await _unitOfWork.Clients.GetByNameAsync(name);
    }

    public async Task<ClientWithOrderCountDto?> GetClientWithMostOrdersAsync()
    {
        return await _unitOfWork.Orders.GetClientWithMostOrdersAsync();
    }

    public async Task<IEnumerable<string>> GetClientsWhoBoughtProductAsync(int productId)
    {
        return await _unitOfWork.Clients.GetClientsWhoBoughtProductAsync(productId);
    }
    
    public async Task<IEnumerable<ClientOrderDto>> GetClientsWithOrdersAsync()
    {
        return await _unitOfWork.Clients.GetClientsWithOrdersAsync();
    }

    public async Task<IEnumerable<object>> GetClientsWithProductCountAsync()
    {
        return await _unitOfWork.Clients.GetClientsWithProductCountAsync();
    }
    
}
