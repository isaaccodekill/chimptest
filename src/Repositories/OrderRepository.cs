using AdventureTime.Models;
using AdventureTIme.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureTIme.Repositories;

public class OrderRepository: IOrderRepository
{
    private readonly AdventureTimeDbContext _context;
    
    public OrderRepository(AdventureTimeDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Order>> GetOrders()
    {
        return await _context.Orders.ToListAsync();
    }
    
    public async Task<Order?> GetOrder(int id)
    {
        // join with SaledOrderDetails table
        return await _context.Orders
            .Where(o => o.SalesOrderId == id)   
            .Include(or => or.Customer)
            .Include(or => or.ShipToAddress)
            .Include(or => or.BillToAddress)
            .Include(ord => ord.SalesOrderDetail)
            .ThenInclude(ord => ord.Product)
            .FirstOrDefaultAsync();
    }
}