using AdventureTIme.Models;

namespace AdventureTIme.Services;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrders();
    Task<Order?> GetOrder(int id);
    
}