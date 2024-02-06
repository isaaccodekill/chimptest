using AdventureTIme.Models;

namespace AdventureTIme.Repositories;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrders();
    Task<Order?> GetOrder(int id);
}