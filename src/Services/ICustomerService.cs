using AdventureTIme.Models;

namespace AdventureTIme.Services;

public interface ICustomerService
{
    Task<IEnumerable<Customer?>> GetCustomers();
    Task<Customer?> GetCustomer(int id);
}