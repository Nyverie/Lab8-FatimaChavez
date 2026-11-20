using Lab8_FatimaChavez.DTOs;
using Lab8_FatimaChavez.Models;
using Lab8_FatimaChavez.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lab8_FatimaChavez.Repositories.Implementations;

public class ClientRepository : GenericRepository<Client>
{
    public ClientRepository(Lab08DbContext context) : base(context) { }

    public async Task<IEnumerable<Client>> GetByNameAsync(string name)
    {
        return await _dbSet
            .Where(c => c.Name.ToLower().Contains(name.ToLower()))
            .ToListAsync();
    }

    public async Task<IEnumerable<string>> GetClientsWhoBoughtProductAsync(int productId)
    {
        return await _context.Orderdetails
            .Where(od => od.Productid == productId)
            .Select(od => od.Order.Client.Name)
            .Distinct()
            .ToListAsync();
    }
    
    public async Task<IEnumerable<ClientOrderDto>> GetClientsWithOrdersAsync()
    {
        var clientOrders = await _context.Clients
            .AsNoTracking()
            .Select(client => new ClientOrderDto
            {
                ClientName = client.Name,
                Orders = client.Orders
                    .Select(order => new OrderDto
                    {
                        OrderId = order.Orderid,
                        OrderDate = order.Orderdate
                    }).ToList()
            }).ToListAsync();

        return clientOrders;
    }
    
}