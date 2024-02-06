using AdventureTIme.Models;
using AdventureTIme.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdventureTIme.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;
    
    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

     [HttpGet]
    public async Task<IActionResult> GetCustomers()
    {
        var customers = await _customerService.GetCustomers();
        return Ok(customers);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomer(int id)
    {
        var customer = await _customerService.GetCustomer(id);
        if (customer != null)
        {
            return Ok(customer);
        }
        else
        {
            return NotFound("Customer not found.");   
        }
    }
    
    
    
}