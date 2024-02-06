using AdventureTIme.Models;
using AdventureTIme.Repositories;

namespace AdventureTIme.Services;

public class OrderService : IOrderService
{
    
    private readonly IOrderRepository _orderRepository;
    
    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }
    
    public async Task<IEnumerable<Order>> GetOrders()
    {
        return await _orderRepository.GetOrders();
    }
    
    public Task<Order?> GetOrder(int id)
    {
        return _orderRepository.GetOrder(id);
    }
}