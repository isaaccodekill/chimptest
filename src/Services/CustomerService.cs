using AdventureTIme.Models;
using AdventureTIme.Repositories;

namespace AdventureTIme.Services;


public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    public async Task<IEnumerable<Customer>> GetCustomers()
    {   
        return await _customerRepository.GetCustomers();
    }
    
    public async Task<Customer?> GetCustomer(int id)
    {
        return await _customerRepository.GetCustomer(id);
    }
}