using AdventureTime.Models;
using AdventureTIme.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureTIme.Repositories;

public class CustomerRepository: ICustomerRepository
{
     private readonly AdventureTimeDbContext _context;
     
     public CustomerRepository(AdventureTimeDbContext context)
     {
         _context = context;
     }
     
     public async Task<IEnumerable<Customer>> GetCustomers()
     {
         var customers = await _context.Customers.ToListAsync();
         return customers;
     }
     
     public async Task<Customer?> GetCustomer(int id)
     {
         var customer = await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == id);
         return customer;
     }
}