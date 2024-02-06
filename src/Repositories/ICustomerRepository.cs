using AdventureTIme.Models;

namespace AdventureTIme.Repositories;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetCustomers();
    
    Task<Customer?> GetCustomer(int id);
}